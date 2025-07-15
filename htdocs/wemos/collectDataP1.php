<?php 

include_once('connects.php');
$p1 = $_GET['p1choice'];

$result = mysqli_query($con,"INSERT INTO gameplay (p1choice) VALUES($p1)");
echo "P1 Success!";

?>