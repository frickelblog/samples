<?php

require_once ("MiniTemplator.class.php");

// Neue template Instanz						
$template = new MiniTemplator;
// Prüfung ob das Template vorhanden ist				
if (!$template->readTemplateFromFile("2.htm")) die ("MiniTemplator.readTemplateFromFile failed.");

// Einfache Variablen setzen						
$template->setVariable ("SeitenTitel","MiniTemplator Demo 2");
$template->setVariable ("Datum",date("d.m.Y"));
$template->setVariable ("Uhrzeit",date("H:i:s"));

// Variablen in einer FOR schleife für eine Tabelle setzen	
for($i=1;$i<=10;$i++)
{
	// Erst die Variebale setzen				
	$template->setVariable ("Inhalt",$i);
	// dann einen neuen <td> Block einfügen		
	$template->addBlock ("td");
	// am ende einen neuen <tr> block einfügen		
	$template->addBlock ("tr");
}

// Template ausgeben							
$template->generateOutput(); 













?>
