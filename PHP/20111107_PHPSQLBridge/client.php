<?php

include("PHPSQLBridge.php");

$PHPSQLBridge = new PHPSQLBridge("http://localhost/test/sqlbridge/server.php");
$array = $PHPSQLBridge->client("SELECT * FROM test3");
print_r($array);

?>


