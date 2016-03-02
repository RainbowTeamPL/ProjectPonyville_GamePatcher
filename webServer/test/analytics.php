<?php
$file = fopen("private/file.txt", "w") or die("Unable to open file!");
foreach ($_POST as $key => $value)
{
    //echo $key . ": ". $value . "\n";
	fwrite($file, "Request: ".$key." : ".$value." From ".getRealUserIp()."\n");	
}

fclose($file);

function getRealUserIp(){
    switch(true){
      case (!empty($_SERVER['HTTP_X_REAL_IP'])) : return $_SERVER['HTTP_X_REAL_IP'];
      case (!empty($_SERVER['HTTP_CLIENT_IP'])) : return $_SERVER['HTTP_CLIENT_IP'];
      case (!empty($_SERVER['HTTP_X_FORWARDED_FOR'])) : return $_SERVER['HTTP_X_FORWARDED_FOR'];
      default : return $_SERVER['REMOTE_ADDR'];
    }
 }
?>