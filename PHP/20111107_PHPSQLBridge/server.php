<?php

include("PHPSQLBridge.php");

$PHPSQLBridge = new PHPSQLBridge();
$PHPSQLBridge->host = "localhost";
$PHPSQLBridge->user = "root";
$PHPSQLBridge->passwd = "";
$PHPSQLBridge->database = "test";

$PHPSQLBridge->server();
?>


