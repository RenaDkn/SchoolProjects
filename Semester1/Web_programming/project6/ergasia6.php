<?php
$link = mysqli_connect("localhost", "root", "", "ergasia6");
if($link === false){
    die("ERROR: Could not connect. " . mysqli_connect_error());
}
$Username = mysqli_real_escape_string($link, $_REQUEST['un']);
$Pass = mysqli_real_escape_string($link, $_REQUEST['pw']);
$Name = mysqli_real_escape_string($link, $_REQUEST['nam']);
$Email = mysqli_real_escape_string($link, $_REQUEST['mail']);
$Age = mysqli_real_escape_string($link, $_REQUEST['age']);
$Date = mysqli_real_escape_string($link, $_REQUEST['hg']);
$Addr = mysqli_real_escape_string($link, $_REQUEST['ad']);
$Pay = mysqli_real_escape_string($link, $_REQUEST['payment']);
$Comment= mysqli_real_escape_string($link, $_REQUEST['sxolio']);

$sql = "INSERT INTO ergasia6(Username,Password,Onoma,Email,Age,Date,Adr,Pay,Comm) VALUES ('$Username', '$Pass', '$Name','$Email','$Age','$Date','$Addr','$Pay','$Comment')";
if(mysqli_query($link, $sql)){
    echo "Records added successfully.";
}
else{
    echo "ERROR: Could not able to execute $sql. " . mysqli_error($link);
}
?>

