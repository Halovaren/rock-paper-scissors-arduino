<?php
include 'connects.php';

$sql = "SELECT D5_status FROM status";
$result = mysqli_query($con, $sql);

if (mysqli_num_rows($result) > 0) {
  // output data of each row
  while($row = mysqli_fetch_assoc($result)) {
    echo $row["D5_status"];
  }
} else {
  echo "0 results";
}
mysqli_close($con);
?>