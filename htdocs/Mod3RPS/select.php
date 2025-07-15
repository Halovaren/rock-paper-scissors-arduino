<?php
include_once('connects.php');

// Assuming you want to pass player1 and player2 as query parameters
$player1_name = $_GET['player1'];
$player2_name = $_GET['player2'];

// Execute the query to fetch the latest player data
$query = "SELECT player1, player2 FROM players ORDER BY id DESC LIMIT 1";
$result = mysqli_query($con, $query); // Use $con here

if ($result) {
    $row = mysqli_fetch_assoc($result);
    if (array_key_exists('player1', $row) && array_key_exists('player2', $row)) {
        $player1 = $row['player1']; 
        $player2 = $row['player2']; 
        echo "$player1, $player2";
    } else {
        echo "Error: Keys not found in the result";
    }
} else {
    error_log("Error executing query: " . mysqli_error($con)); // Use $con here
    echo "Error fetching data";
}
?>