<?php
error_reporting(E_ALL ^ E_NOTICE);

require_once("rb.php");
require_once("MiniTemplator.class.php");


// Datenbank erstellen und ersten Datensatz anlegen
R::setup("sqlite:gb.db3"); 

$Eintraege_Gesamt = R::count("gb");

if($Eintraege_Gesamt==0)
{
// Datensatz anlegen	
	$eintrag = R::dispense("gb");
	$eintrag->name 	= "Sven";
	$eintrag->email = "sven@mails-doch-einfach.de";
	$eintrag->text 	= "Dies ist der erste Eintrag :-)";
	$id = R::store($eintrag);
}

// Neuer Eintrag		
if($_POST['action']=="save")
{
	$eintrag = R::dispense("gb");
	$eintrag->name 	= $_POST['name'];
	$eintrag->email = $_POST['email'];
	$eintrag->text 	= $_POST['text'];
	$id = R::store($eintrag);
}


// Neue template Instanz						
$template = new MiniTemplator;
// Prüfung ob das Template vorhanden ist				
if (!$template->readTemplateFromFile("gb.htm")) die ("MiniTemplator.readTemplateFromFile failed.");

// Einfache Variablen setzen						
$template->setVariable ("SeitenTitel","Gästebuch");
$template->setVariable ("Datum",date("d.m.Y"));
$template->setVariable ("Uhrzeit",date("H:i:s"));

// Variablen in einer FOR schleife für eine Tabelle setzen	
$eintraege = R::find("gb", " id > 0 "); 
foreach($eintraege as $eintrag) 
{
	//echo "ID: ".$book->id." / Titel: ".$book->title."<br>";
	// Erst die Variebale setzen				
	$template->setVariable ("ID",$eintrag->id);
	$template->setVariable ("Name",$eintrag->name);
	$template->setVariable ("Email",$eintrag->email);
	$template->setVariable ("Inhalt",nl2br($eintrag->text));
	// dann einen neuen <td> Block einfügen		
	$template->addBlock ("td");
	// am ende einen neuen <tr> block einfügen		
	$template->addBlock ("tr");
}

// Template ausgeben							
$template->generateOutput(); 













?>
