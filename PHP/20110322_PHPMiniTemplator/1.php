<?php

require_once ("MiniTemplator.class.php");

// Neue template Instanz				
$template = new MiniTemplator;
// Prüfung ob das Template vorhanden ist		
if (!$template->readTemplateFromFile("1.htm")) die ("MiniTemplator.readTemplateFromFile failed.");

// Einfache Variablen setzen				
$template->setVariable ("SeitenTitel","MiniTemplator Demo 1");
$template->setVariable ("Datum",date("d.m.Y"));
$template->setVariable ("Uhrzeit",date("H:i:s"));

// Template ausgeben					
$template->generateOutput(); 

?>
