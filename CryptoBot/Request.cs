using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Security.Cryptography;
using System.Globalization;

namespace CryptoBot
{
	static class Request
	{
		static string publicAPIkey;
		public static string PublicAPIkey
		{
			get { return publicAPIkey; }
			set { publicAPIkey = value; }
		}
		static string secretAPIkey;
		public static string SecretAPIkey
		{
			get { return secretAPIkey; }
			set { secretAPIkey = value; }
		}
		public static string Do(string site)
		{
			try
			{
				//WebRequest request = WebRequest.Create(address);
				//WebResponse response = request.GetResponse();
				HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(site);
				HttpWebResponse response = (HttpWebResponse)request.GetResponse();
				string line = "";
				using (Stream stream = response.GetResponseStream())
				{
					StreamReader sr = new StreamReader(stream);
					line = sr.ReadToEnd();
					stream.Close();
				}
				response.Close();
				return line;
			}
			catch (Exception ex)
			{
				//MessageBox.Show(ex.Message);
				return "No internet";
			}
		}
		public static string Do_withAPIkey(string site, string method)
		{
			try
			{
				//WebRequest request = WebRequest.Create(address);
				//WebResponse response = request.GetResponse();
				HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(site);
				request.Headers.Add("X-MBX-APIKEY: " + PublicAPIkey);
				request.Method = method; //"GET";
				HttpWebResponse response = (HttpWebResponse)request.GetResponse();
				string line = "";
				using (Stream stream = response.GetResponseStream())
				{
					StreamReader sr = new StreamReader(stream);
					line = sr.ReadToEnd();
					stream.Close();
				}
				response.Close();
				return line;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return "No internet";
			}
		}
		public static string Do_withAPIkey2(string site, string method, string parapaparams)
		{
			try
			{
				//WebRequest request = WebRequest.Create(address);
				//WebResponse response = request.GetResponse();
				HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(site);
				request.Headers.Add("X-MBX-APIKEY: " + PublicAPIkey);
				request.Method = method; //"GET";

				request.ContentLength = parapaparams.Length;
				using (var writer = new StreamWriter(request.GetRequestStream()))
				{
					writer.Write(parapaparams);
				}

				HttpWebResponse response = (HttpWebResponse)request.GetResponse();
				string line = "";
				using (Stream stream = response.GetResponseStream())
				{
					StreamReader sr = new StreamReader(stream);
					line = sr.ReadToEnd();
					stream.Close();
				}
				response.Close();
				return line;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return "No internet";
			}
		}
	}
}
