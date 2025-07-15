<?php
include 'connects.php';

$query = "SELECT * FROM rps WHERE playerid = 1";
$result = mysqli_query($conn, $query);

if (mysqli_num_rows($result) > 0) {
    while($row = mysqli_fetch_assoc($result)) {
        $formchoice = $row["formchoice"];
        $score = $row["score"];
        $playerid = $row["playerid"];
        
        // Assuming you want to display the image and score in HTML
        echo "<img src='C:/Users/pvsal/OneDrive/Desktop/IT152P/IT152P and IT153P Module 3 Project/RPSwithVS/IT152PP/IT152PP/images/" . $formchoice . ".png' />";
        echo "<p>Score: " . $score . "</p>";
    }
} else {
    echo "No results found.";
}

mysqli_close($conn);
?>
