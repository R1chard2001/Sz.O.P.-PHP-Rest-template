<?php
// bejelentkezés külön "endpoint"-ban történik
include("./db.php");
$request = $_SERVER['REQUEST_METHOD'];

switch ($request) {
	case "GET":
		if (!empty($_GET["username"]) && !empty($_GET["password"])) {
			if (login($_GET["username"], $_GET["password"])) {
				echo json_encode(array(
						'error' => 0,
						'message' => 'Succesfully logged in!'
					)
				);
			}
			else {
				echo json_encode(array(
						'error' => 1,
						'message' => 'User does not exists!'
					)
				);
			}
			
		} else {
			echo json_encode(array(
					'error' => 1,
					'message' => 'Missing username or password!'
				)
			);
		}
		break;
	default:
		header('HTTP/1.1 405 Method Not Allowed');
		header('Allow: GET');
		break;
}

function login($u, $p) {
	global $con;
	
	$result = count($con -> query("SELECT * FROM users WHERE username = '$u' AND password = MD5('$p');") -> fetch_all());
	return $result > 0;
}


?>