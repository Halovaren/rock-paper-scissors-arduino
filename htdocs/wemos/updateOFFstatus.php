<?php
include 'connects.php';

$sql = "UPDATE `status` SET `D5_status`='0'";
mysqli_query($con, $sql);
?>