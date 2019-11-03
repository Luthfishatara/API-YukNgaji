<?php


$host = "localhost";
$name = "root";
$pswd = "";
$db = "yukngaji";

$con = mysqli_connect($host, $name, $pswd, $db);

    $sqlsantri = "SELECT COUNT(Id) AS totals FROM santri";
    $results = mysqli_query($con, $sqlsantri);
    $valuess = mysqli_fetch_assoc($results);
    $num_rows = $valuess['totals'];
    $_SESSION['totalsantri'] = $num_rows;
    $totals = $num_rows;

    $sqlustad = "SELECT COUNT(Id) AS totalu FROM ustad";
    $resultu = mysqli_query($con, $sqlustad);
    $valuesu = mysqli_fetch_assoc($resultu);
    $num_rowu = $valuesu['totalu'];
    $_SESSION['totalustad'] = $num_rowu;
    $totalu = $num_rowu;

    $sqltotal = $totals + $totalu;

?>