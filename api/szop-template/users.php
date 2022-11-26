<?php

include("./db.php");
include("./common.php");

$request = $_SERVER['REQUEST_METHOD']; // kérés fajtájának lekérdezése

switch ($request) {
	case "GET":
		// megnézni, hogy be vagyunk-e jelentkezve, ezeket paramétereken keresztül átadjuk
		if (empty($_GET["current_user_name"]) || 
			empty($_GET["current_user_password"]) || 
			!userExist($_GET["current_user_name"], $_GET["current_user_password"])) {
			echo json_encode( // tájékoztatjuk a felhasználót a hibáról
				array(
					'error' => 1,
					'message' => 'Login required! Missing or invalid username/password.'
				)
			);
			exit;
		}
	
		echo json_encode( // tájékoztatjuk a felhasználót, és átküldük az adatokat
			array(
				'error' => 0,
				'message' => 'Showing user list',
				'users' => getUsers()
			)
		);
		break;
	case "POST":
		if (empty($_POST["current_user_name"]) || 
			empty($_POST["current_user_password"]) || 
			!userExist($_POST["current_user_name"], $_POST["current_user_password"])) {
				echo json_encode( 
				array(
					'error' => 1,
					'message' => 'Login required! Missing or invalid username/password.'
				)
			);
			exit;
		}
	
		if (!empty($_POST["new_user_name"]) && !empty($_POST["new_user_password"]))
		{
			addNewUser($_POST["new_user_name"],$_POST["new_user_password"]);
		}
		else {
			echo json_encode(array(
						'error' => 1,
						'message' => 'Missing username or password!'
					)
				);
		}
		break;
	case "PUT":
		// a body lekérdezése
		$content = file_get_contents('php://input');
		$data = json_decode($content, true);
		// majd szokásos módon a bejelentkezés ellenőrzése
		if (empty($data["current_user_name"]) || 
			empty($data["current_user_password"]) || 
			!userExist($data["current_user_name"], $data["current_user_password"])) {
				echo json_encode( 
				array(
					'error' => 1,
					'message' => 'Login required! Missing or invalid username/password.'
				)
			);
			exit;
		}
		
		if (!empty($data["id"]) && !empty($data["new_user_name"])) {
			if (empty($data["new_user_password"])) {
				updateUser($data["id"], $data["new_user_name"], "");
			}
			else {
				updateUser($data["id"], $data["new_user_name"], $data["new_user_password"]);
			}
			
		}
		else {
			echo json_encode(array(
						'error' => 1,
						'message' => 'Missing id, username!'
					)
				);
		}
		break;
	case "DELETE":
		$content = file_get_contents('php://input');
		$data = json_decode($content, true);
		
		if (empty($data["current_user_name"]) || 
			empty($data["current_user_password"]) || 
			!userExist($data["current_user_name"], $data["current_user_password"])) {
				echo json_encode( 
				array(
					'error' => 1,
					'message' => 'Login required! Missing or invalid username/password.'
				)
			);
			exit;
		}
		
		if (!empty($data["id"]))
		delUser($data["id"]);
		break;
	default:
		header('HTTP/1.1 405 Method Not Allowed');
		header('Allow: GET, POST, PUT, DELETE');
		break;
}

function getUsers() {
	global $con;
	
	$result = $con -> query("SELECT * FROM users;");
	
	return $result->fetch_all(MYSQLI_ASSOC);
}
function login($u, $p) {
	global $con;
	$result = count($con -> query("SELECT * FROM users WHERE username = '$u' AND password = MD5('$p');") -> fetch_all());
	return $result > 0;
}

function addNewUser($username, $password) {
	global $con;
	$count = count($con -> query("SELECT * FROM users WHERE username = '$username';") -> fetch_all(MYSQLI_ASSOC));
	if ($count == 0) {
		$result = $con -> query("INSERT INTO users (username, password) VALUES ('$username', md5('$password'));");
		echo json_encode(
			array(
				'error' => 0,
				'message' => 'New user added!'
			)
		);
	}
	else {
		echo json_encode(array(
				'error' => 1,
				'message' => 'User already exists!'
			)
		);
	}
}


function updateUser($id, $username, $password) {
	global $con;
	$count = count($con -> query("SELECT * FROM users WHERE username = '$username' and id != $id;") -> fetch_all(MYSQLI_ASSOC));
	if ($count == 0) {
		if ($password == "") {
			$con -> query("UPDATE users SET username = '$username' WHERE id = $id;");
		}
		else {
			$con -> query("UPDATE users SET username = '$username', password = md5('$password') WHERE id = $id;");
		}
		echo json_encode(
			array(
				'error' => 0,
				'message' => 'User updated successfully!'
			)
		);
	}
	else {
		echo json_encode(array(
				'error' => 1,
				'message' => 'User already exists!'
			)
		);
	}
}

function delUser($id) {
	global $con;
	$con -> query("DELETE FROM users WHERE id = '$id';");
	echo json_encode(
		array(
			'error' => 0,
			'message' => 'User deleted successfully!'
		)
	);
	$con -> close();
}
?>