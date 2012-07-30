<?php

require_once ("MiniTemplator.class.php");

// Neue template Instanz						
$template = new MiniTemplator;
// Prüfung ob das Template vorhanden ist				
if (!$template->readTemplateFromFile("3.htm")) die ("MiniTemplator.readTemplateFromFile failed.");

// Einfache Variablen setzen						
$template->setVariable ("SeitenTitel","MiniTemplator Demo 3");
$template->setVariable ("Datum",date("d.m.Y"));
$template->setVariable ("Uhrzeit",date("H:i:s"));

// Variablen in einer FOR schleife für eine Tabelle setzen	
for($i_zeile=1;$i_zeile<=20;$i_zeile++)
{
	for($i_spalte=1;$i_spalte<=10;$i_spalte++)
	{
		// Erst die Variebale setzen				
		$template->setVariable ("Zeile",$i_zeile);
		$template->setVariable ("Spalte",$i_spalte);
		// dann einen neuen <td> Block einfügen		
		$template->addBlock ("td");
	}

	// am ende einen neuen <tr> block einfügen			
	$template->addBlock ("tr");
}

// Template ausgeben							
$template->generateOutput(); 













?>
