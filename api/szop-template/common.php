<?php

include("./db.php");

// sok helyen előforduló függvények helye (ha több endpoint van, nem kell újra leírni ezeket)

function userExist($u, $p) {
	global $con;
	
	$result = count($con -> query("SELECT * FROM users WHERE username = '$u' AND password = MD5('$p');") -> fetch_all());
	return $result > 0;
}

/*
// ha lenne adminkezelés is benne (+1 oszlop az adatbázisban)
function adminExist($u, $p) {
	global $con;
	
	$result = count($con -> query("SELECT * FROM users WHERE username = '$u' AND password = MD5('$p') and is_admin = 1;") -> fetch_all());
	return $result > 0;
}
*/

?>