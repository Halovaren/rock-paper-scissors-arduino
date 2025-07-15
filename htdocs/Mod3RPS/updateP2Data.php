<?php 

include_once('connects.php');
$message = $_GET['P2HandChoice'];

$result = mysqli_query($con,"UPDATE `rps` SET `formchoice`='$message',`haschosen`='true' WHERE playerid = 2");
echo "P1 succuess!";

?>