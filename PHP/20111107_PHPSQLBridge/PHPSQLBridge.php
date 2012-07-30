<?
/*
-------------------------------------------------------------------------
Server:
-------------------------------------------------------------------------
include("PHPSQLBridge.php");
$PHPSQLBridge = new PHPSQLBridge();
$PHPSQLBridge->host = "localhost";
$PHPSQLBridge->user = "root";
$PHPSQLBridge->passwd = "";
$PHPSQLBridge->database = "test";

$PHPSQLBridge->server();

-------------------------------------------------------------------------
Cleint:
-------------------------------------------------------------------------
include("PHPSQLBridge.php");
$PHPSQLBridge = new PHPSQLBridge("http://localhost/test/sqlbridge/server.php");
$array = $PHPSQLBridge->client("SELECT * FROM test3");

print_r($array);
-------------------------------------------------------------------------
*/

class PHPSQLBridge
{
    public $host = "";
	public $user = "";
	public $passwd = "";
	public $database = "";
	
	public $Serialisierung = "PHP"; // "PHP" oder "JSON"
	
	private $ServerURL;

	public function __construct($ServerURL="") 
	{
		$this->ServerURL = $ServerURL;
    }
	
    public function server()
	{
		mysql_connect($this->host,$this->user,$this->passwd);
		
		mysql_select_db($this->database);
		
		if(!empty($_GET['qry']))
		{
			$qry = base64_decode($_GET['qry']);
		}
		else
		{
			$qry = "SHOW VARIABLES LIKE '%version%';";
		}

		$res = mysql_query($qry);
		
		while($array[]=mysql_fetch_array($res));
		
		if($this->Serialisierung=="PHP")
		{	
			echo serialize($array);
		}
		
		if($this->Serialisierung=="JSON")
		{	
			echo json_encode($array);
		}
	}
	
	public function client($qry)
	{
		$inhalt = file_get_contents($this->ServerURL."?qry=".base64_encode($qry)."");
		
		if($this->Serialisierung=="PHP")
		{	
			return unserialize($inhalt);
		}
		
		if($this->Serialisierung=="JSON")
		{	
			return json_decode($inhalt);
		}
	} 
}

?>