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
	public partial class Account : Form
	{
		string[] symbols = { "ETHBTC", "LTCBTC", "BNBBTC", "NEOBTC", "123456", "QTUMETH", "EOSETH", "SNTETH", "BNTETH", "BCCBTC", "GASBTC", "BNBETH", "BTCUSDT", "ETHUSDT", "HSRBTC", "OAXETH", "DNTETH", "MCOETH", "ICNETH", "MCOBTC", "WTCBTC", "WTCETH", "LRCBTC", "LRCETH", "QTUMBTC", "YOYOBTC", "OMGBTC", "OMGETH", "ZRXBTC", "ZRXETH", "STRATBTC", "STRATETH", "SNGLSBTC", "SNGLSETH", "BQXBTC", "BQXETH", "KNCBTC", "KNCETH", "FUNBTC", "FUNETH", "SNMBTC", "SNMETH", "NEOETH", "IOTABTC", "IOTAETH", "LINKBTC", "LINKETH", "XVGBTC", "XVGETH", "CTRBTC", "CTRETH", "SALTBTC", "SALTETH", "MDABTC", "MDAETH", "MTLBTC", "MTLETH", "SUBBTC", "SUBETH", "EOSBTC", "SNTBTC", "ETCETH", "ETCBTC", "MTHBTC", "MTHETH", "ENGBTC", "ENGETH", "DNTBTC", "ZECBTC", "ZECETH", "BNTBTC", "ASTBTC", "ASTETH", "DASHBTC", "DASHETH", "OAXBTC", "ICNBTC", "BTGBTC", "BTGETH", "EVXBTC", "EVXETH", "REQBTC", "REQETH", "VIBBTC", "VIBETH", "HSRETH", "TRXBTC", "TRXETH", "POWRBTC", "POWRETH", "ARKBTC", "ARKETH", "YOYOETH", "XRPBTC", "XRPETH", "MODBTC", "MODETH", "ENJBTC", "ENJETH", "STORJBTC", "STORJETH", "BNBUSDT", "VENBNB", "YOYOBNB", "POWRBNB", "VENBTC", "VENETH", "KMDBTC", "KMDETH", "NULSBNB", "RCNBTC", "RCNETH", "RCNBNB", "NULSBTC", "NULSETH", "RDNBTC", "RDNETH", "RDNBNB", "XMRBTC", "XMRETH", "DLTBNB", "WTCBNB", "DLTBTC", "DLTETH", "AMBBTC", "AMBETH", "AMBBNB", "BCCETH", "BCCUSDT", "BCCBNB", "BATBTC", "BATETH", "BATBNB", "BCPTBTC", "BCPTETH", "BCPTBNB", "ARNBTC", "ARNETH", "GVTBTC", "GVTETH", "CDTBTC", "CDTETH", "GXSBTC", "GXSETH", "NEOUSDT", "NEOBNB", "POEBTC", "POEETH", "QSPBTC", "QSPETH", "QSPBNB", "BTSBTC", "BTSETH", "BTSBNB", "XZCBTC", "XZCETH", "XZCBNB", "LSKBTC", "LSKETH", "LSKBNB", "TNTBTC", "TNTETH", "FUELBTC", "FUELETH", "MANABTC", "MANAETH", "BCDBTC", "BCDETH", "DGDBTC", "DGDETH", "IOTABNB", "ADXBTC", "ADXETH", "ADXBNB", "ADABTC", "ADAETH", "PPTBTC", "PPTETH", "CMTBTC", "CMTETH", "CMTBNB", "XLMBTC", "XLMETH", "XLMBNB", "CNDBTC", "CNDETH", "CNDBNB", "LENDBTC", "LENDETH", "WABIBTC", "WABIETH", "WABIBNB", "LTCETH", "LTCUSDT", "LTCBNB", "TNBBTC", "TNBETH", "WAVESBTC", "WAVESETH", "WAVESBNB", "GTOBTC", "GTOETH", "GTOBNB", "ICXBTC", "ICXETH", "ICXBNB", "OSTBTC", "OSTETH", "OSTBNB", "ELFBTC", "ELFETH", "AIONBTC", "AIONETH", "AIONBNB", "NEBLBTC", "NEBLETH", "NEBLBNB", "BRDBTC", "BRDETH", "BRDBNB", "MCOBNB", "EDOBTC", "EDOETH", "WINGSBTC", "WINGSETH", "NAVBTC", "NAVETH", "NAVBNB", "LUNBTC", "LUNETH", "TRIGBTC", "TRIGETH", "TRIGBNB", "APPCBTC", "APPCETH", "APPCBNB", "VIBEBTC", "VIBEETH", "RLCBTC", "RLCETH", "RLCBNB", "INSBTC", "INSETH", "PIVXBTC", "PIVXETH", "PIVXBNB" };
		string AccInfo = "https://api.binance.com/api/v3/account";
		string TradeList = "https://api.binance.com/api/v3/myTrades";
		public Account()
		{
			InitializeComponent();
			SymbolChoiceComboBox.Items.AddRange(symbols);
		}

		private void SymbolChoiceComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (SymbolChoiceComboBox.SelectedItem != "")
				TradeListButton.Enabled = true;
			else
				TradeListButton.Enabled = false;
		}

		private void AccInfoButton_Click(object sender, EventArgs e)
		{
			long timestamp = (long)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalMilliseconds;
			string address = "timestamp=" + timestamp;
			string signature = HmacSha256Digest(address, Request.SecretAPIkey);
			address = address + "&signature=" + signature;

			string line = Request.Do_withAPIkey(AccInfo + "?" + address, "GET");
			AccountInformation_JSON AccountInformation = JsonConvert.DeserializeObject<AccountInformation_JSON>(line);
			textBox1.Text = "";
			textBox1.Text += "makerCommission: " + AccountInformation.makerCommission + Environment.NewLine;
			textBox1.Text += "takerCommission: " + AccountInformation.takerCommission + Environment.NewLine;
			textBox1.Text += "buyerCommission: " + AccountInformation.buyerCommission + Environment.NewLine;
			textBox1.Text += "sellerCommission: " + AccountInformation.sellerCommission + Environment.NewLine;
			textBox1.Text += "Может торговать: " + (AccountInformation.canTrade == true ? "Да" : "Нет") + Environment.NewLine;
			textBox1.Text += "Может выводить: " + (AccountInformation.canWithdraw == true ? "Да" : "Нет") + Environment.NewLine;
			textBox1.Text += "Может вносить депозиты: " + (AccountInformation.canDeposit == true ? "Да" : "Нет") + Environment.NewLine;
			textBox1.Text += Environment.NewLine + "Баланс: " + Environment.NewLine;
			textBox1.Text += "Монета\tКоличество\tЗаблокировано" + Environment.NewLine;
			for (int i = 0; i < AccountInformation.balances.Count; i++)
			{
				textBox1.Text += AccountInformation.balances[i].asset + "\t" + AccountInformation.balances[i].free + "\t" + AccountInformation.balances[i].locked + Environment.NewLine;
			}
		}
		string HmacSha256Digest(string message, string secret)
		{
			ASCIIEncoding encoding = new ASCIIEncoding();
			byte[] keyBytes = encoding.GetBytes(secret);
			byte[] messageBytes = encoding.GetBytes(message);
			System.Security.Cryptography.HMACSHA256 cryptographer = new System.Security.Cryptography.HMACSHA256(keyBytes);
			byte[] bytes = cryptographer.ComputeHash(messageBytes);
			return BitConverter.ToString(bytes).Replace("-", "").ToLower();
		}

		private void TradeListButton_Click(object sender, EventArgs e)
		{
			long timestamp = (long)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalMilliseconds;
			string address = "symbol=" + SymbolChoiceComboBox.SelectedItem.ToString() + "&timestamp=" + timestamp;
			string signature = HmacSha256Digest(address, Request.SecretAPIkey);
			address = address + "&signature=" + signature;

			string line = Request.Do_withAPIkey(TradeList + "?" + address, "GET");
			textBox1.Text = "";
			if (line == "[]")
				textBox1.Text = "Нет сделок с данной парой";
			else
			{
				List<string> stringTrades = SplitRecords(line);
				List<AccountTradeList_JSON> TradesList = new List<AccountTradeList_JSON>();
				foreach (string s in stringTrades)
					TradesList.Add(JsonConvert.DeserializeObject<AccountTradeList_JSON>(s));
				foreach (AccountTradeList_JSON trade in TradesList)
				{
					textBox1.Text += "id : " + trade.id + Environment.NewLine;
					textBox1.Text += "id сделки: " + trade.orderId + Environment.NewLine;
					textBox1.Text += "Цена: " + trade.price + Environment.NewLine;
					textBox1.Text += "Количество: " + trade.qty + Environment.NewLine;
					textBox1.Text += "Комиссия: " + trade.commission + Environment.NewLine;
					textBox1.Text += "Валюта комиссии: " + trade.commissionAsset + Environment.NewLine;
					textBox1.Text += "Время: " + trade.time + Environment.NewLine;
					textBox1.Text += "Роль: " + (trade.isBuyer ? "покупатель" : "продавец") + Environment.NewLine;
					textBox1.Text += "Лучший вариант: " + (trade.isBestMatch ? "да" : "нет") + Environment.NewLine;
					textBox1.Text += Environment.NewLine;
				}
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
	}
}