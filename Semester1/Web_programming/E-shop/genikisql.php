<?php
$link = mysqli_connect("localhost", "root", "", "geniki");
if($link === false){
    die("ERROR: Could not connect. " . mysqli_connect_error());
}
$Name = mysqli_real_escape_string($link, $_REQUEST['nam']);
$Email = mysqli_real_escape_string($link, $_REQUEST['mail']);
$Size = mysqli_real_escape_string($link, $_REQUEST['size']);
$Addr = mysqli_real_escape_string($link, $_REQUEST['ad']);
$Pay = mysqli_real_escape_string($link, $_REQUEST['payment']);
$Comment= mysqli_real_escape_string($link, $_REQUEST['sxolio']);
$Pos1 = mysqli_real_escape_string($link, $_REQUEST['p11']);
$Pos2 = mysqli_real_escape_string($link, $_REQUEST['p12']);
$Pos3 = mysqli_real_escape_string($link, $_REQUEST['p13']);
$Pos4 = mysqli_real_escape_string($link, $_REQUEST['p14']);
$Pos5 = mysqli_real_escape_string($link, $_REQUEST['p15']);
$sql = "INSERT INTO geniki(Onoma,Email,Size,Adr,Pay,Comm,Pos1,Pos2,Pos3,Pos4,Timi) VALUES ('$Name','$Email','$Size','$Addr','$Pay','$Comment','$Pos1','$Pos2','$Pos3','$Pos4','$Pos5')";
//elegxei ean bikanta arxia sto database
if(mysqli_query($link, $sql)){
    echo "Records added successfully.";
}
else{
    echo "ERROR: Could not able to execute $sql. " . mysqli_error($link);
}
?>