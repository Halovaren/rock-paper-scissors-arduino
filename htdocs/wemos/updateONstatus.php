<?php
include 'connects.php';

$sql = "UPDATE `status` SET `D5_status`='1'";
mysqli_query($con, $sql);
?>