using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Net;
using System.IO;

namespace BildDownload
{
	static class Funktionen
	{
		public static Image GetImageFromURL(string url)
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)HttpWebRequest.Create(url);
			HttpWebResponse httpWebReponse = (HttpWebResponse)httpWebRequest.GetResponse();
			Stream stream = httpWebReponse.GetResponseStream();
			return Image.FromStream(stream);
		}

	}
}
