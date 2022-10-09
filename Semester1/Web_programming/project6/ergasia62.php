<?php
    $link = mysqli_connect("localhost", "root", "", "ergasia6");
    if($link === false){
        die("ERROR: Could not connect. " . mysqli_connect_error());
    }
    $Email = mysqli_real_escape_string($link, $_REQUEST['sm']);
    $Username = mysqli_real_escape_string($link, $_REQUEST['su']);
    if(empty($Email)){
        $sql="SELECT * FROM ergasia6 WHERE Username LIKE '%$Username%'";
    }
    else if (empty($Username)){
        $sql="SELECT * FROM ergasia6 WHERE Email LIKE '%$Email%'";
    }
    else{
        $sql="SELECT * FROM ergasia6 WHERE Username LIKE '%$Username%' AND Email LIKE '%$Email%'";
    }
    if($result = mysqli_query($link, $sql)){
        if(mysqli_num_rows($result) > 0){
            echo "<table>";
                echo "<tr>";
                    echo "<th>Username</th>";
                    echo "<th>Password</th>";
                    echo "<th>Onoma</th>";
                    echo "<th>Email</th>";
                    echo "<th>Age</th>";
                    echo "<th>Date</th>";
                    echo "<th>Adr</th>";
                    echo "<th>Pay</th>";
                    echo "<th>Comm</th>";
                echo "</tr>";
            while($row = mysqli_fetch_array($result)){
                echo "<tr>";
                    echo "<td>" . $row['Username'] . "</td>";
                    echo "<td>" . $row['Password'] . "</td>";
                    echo "<td>" . $row['Onoma'] . "</td>";
                    echo "<td>" . $row['Email'] . "</td>";                    
                    echo "<td>" . $row['Age'] . "</td>"; 
                    echo "<td>" . $row['Date'] . "</td>"; 
                    echo "<td>" . $row['Adr'] . "</td>"; 
                    echo "<td>" . $row['Pay'] . "</td>"; 
                    echo "<td>" . $row['Comm'] . "</td>"; 
                echo "</tr>";
            }
            echo "</table>";
            mysqli_free_result($result);
        } else{
            echo "No records matching your query were found.";
        }
    }
?>