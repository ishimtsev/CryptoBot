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
	public partial class NewOrder : Form
	{
		string[] symbols = { "ETHBTC", "LTCBTC", "BNBBTC", "NEOBTC", "123456", "QTUMETH", "EOSETH", "SNTETH", "BNTETH", "BCCBTC", "GASBTC", "BNBETH", "BTCUSDT", "ETHUSDT", "HSRBTC", "OAXETH", "DNTETH", "MCOETH", "ICNETH", "MCOBTC", "WTCBTC", "WTCETH", "LRCBTC", "LRCETH", "QTUMBTC", "YOYOBTC", "OMGBTC", "OMGETH", "ZRXBTC", "ZRXETH", "STRATBTC", "STRATETH", "SNGLSBTC", "SNGLSETH", "BQXBTC", "BQXETH", "KNCBTC", "KNCETH", "FUNBTC", "FUNETH", "SNMBTC", "SNMETH", "NEOETH", "IOTABTC", "IOTAETH", "LINKBTC", "LINKETH", "XVGBTC", "XVGETH", "CTRBTC", "CTRETH", "SALTBTC", "SALTETH", "MDABTC", "MDAETH", "MTLBTC", "MTLETH", "SUBBTC", "SUBETH", "EOSBTC", "SNTBTC", "ETCETH", "ETCBTC", "MTHBTC", "MTHETH", "ENGBTC", "ENGETH", "DNTBTC", "ZECBTC", "ZECETH", "BNTBTC", "ASTBTC", "ASTETH", "DASHBTC", "DASHETH", "OAXBTC", "ICNBTC", "BTGBTC", "BTGETH", "EVXBTC", "EVXETH", "REQBTC", "REQETH", "VIBBTC", "VIBETH", "HSRETH", "TRXBTC", "TRXETH", "POWRBTC", "POWRETH", "ARKBTC", "ARKETH", "YOYOETH", "XRPBTC", "XRPETH", "MODBTC", "MODETH", "ENJBTC", "ENJETH", "STORJBTC", "STORJETH", "BNBUSDT", "VENBNB", "YOYOBNB", "POWRBNB", "VENBTC", "VENETH", "KMDBTC", "KMDETH", "NULSBNB", "RCNBTC", "RCNETH", "RCNBNB", "NULSBTC", "NULSETH", "RDNBTC", "RDNETH", "RDNBNB", "XMRBTC", "XMRETH", "DLTBNB", "WTCBNB", "DLTBTC", "DLTETH", "AMBBTC", "AMBETH", "AMBBNB", "BCCETH", "BCCUSDT", "BCCBNB", "BATBTC", "BATETH", "BATBNB", "BCPTBTC", "BCPTETH", "BCPTBNB", "ARNBTC", "ARNETH", "GVTBTC", "GVTETH", "CDTBTC", "CDTETH", "GXSBTC", "GXSETH", "NEOUSDT", "NEOBNB", "POEBTC", "POEETH", "QSPBTC", "QSPETH", "QSPBNB", "BTSBTC", "BTSETH", "BTSBNB", "XZCBTC", "XZCETH", "XZCBNB", "LSKBTC", "LSKETH", "LSKBNB", "TNTBTC", "TNTETH", "FUELBTC", "FUELETH", "MANABTC", "MANAETH", "BCDBTC", "BCDETH", "DGDBTC", "DGDETH", "IOTABNB", "ADXBTC", "ADXETH", "ADXBNB", "ADABTC", "ADAETH", "PPTBTC", "PPTETH", "CMTBTC", "CMTETH", "CMTBNB", "XLMBTC", "XLMETH", "XLMBNB", "CNDBTC", "CNDETH", "CNDBNB", "LENDBTC", "LENDETH", "WABIBTC", "WABIETH", "WABIBNB", "LTCETH", "LTCUSDT", "LTCBNB", "TNBBTC", "TNBETH", "WAVESBTC", "WAVESETH", "WAVESBNB", "GTOBTC", "GTOETH", "GTOBNB", "ICXBTC", "ICXETH", "ICXBNB", "OSTBTC", "OSTETH", "OSTBNB", "ELFBTC", "ELFETH", "AIONBTC", "AIONETH", "AIONBNB", "NEBLBTC", "NEBLETH", "NEBLBNB", "BRDBTC", "BRDETH", "BRDBNB", "MCOBNB", "EDOBTC", "EDOETH", "WINGSBTC", "WINGSETH", "NAVBTC", "NAVETH", "NAVBNB", "LUNBTC", "LUNETH", "TRIGBTC", "TRIGETH", "TRIGBNB", "APPCBTC", "APPCETH", "APPCBNB", "VIBEBTC", "VIBEETH", "RLCBTC", "RLCETH", "RLCBNB", "INSBTC", "INSETH", "PIVXBTC", "PIVXETH", "PIVXBNB" };
		string BaseAddress = "https://api.binance.com/api/v3/order";
		string TestBaseAddress = "https://api.binance.com/api/v3/order/test";//"https://api.binance.com/api/v3/order/test";
		public NewOrder()
		{
			InitializeComponent();
			SymbolChoiceComboBox.Items.AddRange(symbols);
		}

		private void OKbutton_Click(object sender, EventArgs e)
		{
			long timestamp = (long)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalMilliseconds;
			string address = "symbol=" + SymbolChoiceComboBox.SelectedItem.ToString()
				+ "&side=" + (BuyRadioButton.Checked ? "BUY" : "SELL")
				+ "&type=" + (LimitRadioButton.Checked ? "LIMIT" : "MARKET")
				+ "&timeInForce=" + (GTCradioButton.Checked ? "GTC" : "IOC")
				+ "&quantity=" + QuantityTextBox.Text + "&price=" + PriceTextBox.Text + "&recvWindow=" + "5000" + "&timestamp=" + timestamp;
			string signature = HmacSha256Digest(address, Request.SecretAPIkey);
			address = address + "&signature=" + signature;

			textBox1.Text = address;

		//	string line = Request.Do_withAPIkey((TestRadioButton.Checked ? TestBaseAddress : BaseAddress) + "?" + address, "POST");
			//string line = Request.Do_withAPIkey2(TestBaseAddress/* + "?" + address*/, "POST", address);

			//textBox1.Text = line;

			//long timestamp = (long)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalMilliseconds;
			//string address = "symbol=" + SymbolChoiceComboBox.SelectedItem.ToString() + "&side="
			//	+ (BuyRadioButton.Checked ? "BUY" : "SELL") + "&type=" + (LimitRadioButton.Checked ? "LIMIT" : "MARKET")
			//	+ "&timeInForce=" + (GTCradioButton.Checked ? "GTC" : "IOC") + "&price=" + PriceTextBox.Text
			//	+ "&quantity=" + QuantityTextBox.Text + "&recvWindow=5000" + "&timestamp=" + timestamp;
			////textBox1.Text += address + Environment.NewLine;
			////string signature = HmacSha256Digest(address, Request.SecretAPIkey);
			////address = address + "&signature=" + signature;
			////textBox1.Text += address + Environment.NewLine;

			////textBox1.Text = Request.Do_withAPIkey(TestBaseAddress + "?" + address);

			////address = "=symbol=LTCBTC&side=BUY&type=LIMIT&timeInForce=GTC&quantity=1&price=0.1&recvWindow=5000&timestamp=1517084285105&signature=9ffcc2c3a30ed010372e1a0d1ec050954a36feee030259c1d0b2bcbcd3f7b1f2";
			////address = "timestamp=" + timestamp;
			////string signature = HmacSha256Digest(address, Request.SecretAPIkey);
			////address = address + "&signature=" + signature;
			//HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(TestBaseAddress + "?" + address);
			//request.Headers.Add("X-MBX-APIKEY: " + Request.PublicAPIkey);
			//request.Method = "GET";
			/////request.Headers["X-MBX-APIKEY"] = Request.PublicAPIkey;
			//HttpWebResponse response = (HttpWebResponse)request.GetResponse();
			//string line = "";
			//using (Stream stream = response.GetResponseStream())
			//{
			//	StreamReader sr = new StreamReader(stream);
			//	line = sr.ReadToEnd();
			//	stream.Close();
			//}
			//response.Close();
			//textBox1.Text = line;
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
		private void Check_Changed(object sender, EventArgs e)
		{
			if ((TestRadioButton.Checked || NotTestRadioButton.Checked) && (SymbolChoiceComboBox.SelectedIndex != -1)
				&& (PriceTextBox.Text != "") && (QuantityTextBox.Text != "")
				&& (GTCradioButton.Checked || IOCradioButton.Checked)
				&& (LimitRadioButton.Checked || MarketRadioButton.Checked)
				&& (BuyRadioButton.Checked || SellRadioButton.Checked))
				OKbutton.Enabled = true;
			else
				OKbutton.Enabled = false;
		}

	}
}
