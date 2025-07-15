<?php 

include_once('connects.php');
$t = $_GET['temp'];
$h = $_GET['humidity'];

$result = mysqli_query($con,"INSERT INTO dht (temp,humidity) VALUES($t,$h)");
echo "weee";

?>