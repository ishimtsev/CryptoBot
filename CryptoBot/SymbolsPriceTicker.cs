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

namespace CryptoBot
{
	public partial class SymbolsPriceTicker : Form
	{
		public SymbolsPriceTicker()
		{
			InitializeComponent();
			Refresh();
		}
		void Refresh()
		{
			string line = Request.Do("https://www.binance.com/api/v1/ticker/allPrices");
			List<string> stringPrices = SplitRecords(line);

			List<SymbolsPriceTicker_JSON> PricesList = new List<SymbolsPriceTicker_JSON>();
			foreach (string s in stringPrices)
				PricesList.Add(JsonConvert.DeserializeObject<SymbolsPriceTicker_JSON>(s));
			textBox1.Text = "Пара\t\tЦена" + Environment.NewLine;
			foreach (SymbolsPriceTicker_JSON price in PricesList)
			{
				textBox1.Text += price.symbol + "\t\t" + price.price + Environment.NewLine;
			}
		}
		List<string> SplitRecords(string line)
		{
			char[] charsToTrim = { '[', ']' };
			line = line.Trim(charsToTrim);
			List<string> records = new List<string>();
			int count = 0; //количество записей в строке
			for (int i = 0; i < line.Length; i++)
				if (line[i] == '}')
					count++;

			int startIndex = 0;
			int endIndex = -2;
			for (int i = 0; i < count; i++)
			{
				startIndex = endIndex + 2;
				endIndex = line.IndexOf('}', startIndex);
				records.Add(line.Substring(startIndex, endIndex - startIndex + 1));
			}
			return records;
		}
		private void RefreshButton_Click(object sender, EventArgs e)
		{
			Refresh();
		}
	}
}
