<?php 

include_once('connects.php');
$message = $_GET['P1HandChoice'];

$result = mysqli_query($con,"UPDATE `rps` SET `formchoice`='$message',`haschosen`='true' WHERE playerid = 1");
echo "P1 succuess!";

?>