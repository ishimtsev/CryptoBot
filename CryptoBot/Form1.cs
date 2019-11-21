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
	public partial class Form1 : Form
	{
		string[] functions = { "Стакан для валютной пары", "Последняя цена каждой пары", "Лучшие предложения по каждой паре" };
		string[] symbols = { "ETHBTC", "LTCBTC", "BNBBTC", "NEOBTC", "123456", "QTUMETH", "EOSETH", "SNTETH", "BNTETH", "BCCBTC", "GASBTC", "BNBETH", "BTCUSDT", "ETHUSDT", "HSRBTC", "OAXETH", "DNTETH", "MCOETH", "ICNETH", "MCOBTC", "WTCBTC", "WTCETH", "LRCBTC", "LRCETH", "QTUMBTC", "YOYOBTC", "OMGBTC", "OMGETH", "ZRXBTC", "ZRXETH", "STRATBTC", "STRATETH", "SNGLSBTC", "SNGLSETH", "BQXBTC", "BQXETH", "KNCBTC", "KNCETH", "FUNBTC", "FUNETH", "SNMBTC", "SNMETH", "NEOETH", "IOTABTC", "IOTAETH", "LINKBTC", "LINKETH", "XVGBTC", "XVGETH", "CTRBTC", "CTRETH", "SALTBTC", "SALTETH", "MDABTC", "MDAETH", "MTLBTC", "MTLETH", "SUBBTC", "SUBETH", "EOSBTC", "SNTBTC", "ETCETH", "ETCBTC", "MTHBTC", "MTHETH", "ENGBTC", "ENGETH", "DNTBTC", "ZECBTC", "ZECETH", "BNTBTC", "ASTBTC", "ASTETH", "DASHBTC", "DASHETH", "OAXBTC", "ICNBTC", "BTGBTC", "BTGETH", "EVXBTC", "EVXETH", "REQBTC", "REQETH", "VIBBTC", "VIBETH", "HSRETH", "TRXBTC", "TRXETH", "POWRBTC", "POWRETH", "ARKBTC", "ARKETH", "YOYOETH", "XRPBTC", "XRPETH", "MODBTC", "MODETH", "ENJBTC", "ENJETH", "STORJBTC", "STORJETH", "BNBUSDT", "VENBNB", "YOYOBNB", "POWRBNB", "VENBTC", "VENETH", "KMDBTC", "KMDETH", "NULSBNB", "RCNBTC", "RCNETH", "RCNBNB", "NULSBTC", "NULSETH", "RDNBTC", "RDNETH", "RDNBNB", "XMRBTC", "XMRETH", "DLTBNB", "WTCBNB", "DLTBTC", "DLTETH", "AMBBTC", "AMBETH", "AMBBNB", "BCCETH", "BCCUSDT", "BCCBNB", "BATBTC", "BATETH", "BATBNB", "BCPTBTC", "BCPTETH", "BCPTBNB", "ARNBTC", "ARNETH", "GVTBTC", "GVTETH", "CDTBTC", "CDTETH", "GXSBTC", "GXSETH", "NEOUSDT", "NEOBNB", "POEBTC", "POEETH", "QSPBTC", "QSPETH", "QSPBNB", "BTSBTC", "BTSETH", "BTSBNB", "XZCBTC", "XZCETH", "XZCBNB", "LSKBTC", "LSKETH", "LSKBNB", "TNTBTC", "TNTETH", "FUELBTC", "FUELETH", "MANABTC", "MANAETH", "BCDBTC", "BCDETH", "DGDBTC", "DGDETH", "IOTABNB", "ADXBTC", "ADXETH", "ADXBNB", "ADABTC", "ADAETH", "PPTBTC", "PPTETH", "CMTBTC", "CMTETH", "CMTBNB", "XLMBTC", "XLMETH", "XLMBNB", "CNDBTC", "CNDETH", "CNDBNB", "LENDBTC", "LENDETH", "WABIBTC", "WABIETH", "WABIBNB", "LTCETH", "LTCUSDT", "LTCBNB", "TNBBTC", "TNBETH", "WAVESBTC", "WAVESETH", "WAVESBNB", "GTOBTC", "GTOETH", "GTOBNB", "ICXBTC", "ICXETH", "ICXBNB", "OSTBTC", "OSTETH", "OSTBNB", "ELFBTC", "ELFETH", "AIONBTC", "AIONETH", "AIONBNB", "NEBLBTC", "NEBLETH", "NEBLBNB", "BRDBTC", "BRDETH", "BRDBNB", "MCOBNB", "EDOBTC", "EDOETH", "WINGSBTC", "WINGSETH", "NAVBTC", "NAVETH", "NAVBNB", "LUNBTC", "LUNETH", "TRIGBTC", "TRIGETH", "TRIGBNB", "APPCBTC", "APPCETH", "APPCBNB", "VIBEBTC", "VIBEETH", "RLCBTC", "RLCETH", "RLCBNB", "INSBTC", "INSETH", "PIVXBTC", "PIVXETH", "PIVXBNB" };
		public Form1()
		{
			InitializeComponent();
			////////
			Request.PublicAPIkey = "";
			Request.SecretAPIkey = "";
			////////
			//string line = Request.Do("https://www.binance.com/api/v1/depth" + "?" + "symbol=ETHBTC");
			//textBox1.Text = line + Environment.NewLine;
			//OrderBook_JSON OrderBook = JsonConvert.DeserializeObject<OrderBook_JSON>(line);

			// /api/v3/openOrders

			//textBox2.Text = "Время обновления: " + OrderBook.lastUpdateId + Environment.NewLine;
			//textBox2.Text += OrderBook.lastUpdateId / 10 + Environment.NewLine;
			//textBox2.Text += HmacSha256Digest("symbol=LTCBTC&side=BUY&type=LIMIT&timeInForce=GTC&quantity=1&price=0.1&recvWindow=5000&timestamp=1517084285105", Request.SecretAPIkey) + Environment.NewLine;

			////var ts = TimeSpan.FromSeconds(OrderBook.lastUpdateId/10);
			//var ts = TimeSpan.FromSeconds(OrderBook.lastUpdateId / 10000);
			//textBox2.Text += ts.Days + " дней, " + ts.Hours + " часов, " + ts.Minutes + " минут, " + ts.Seconds + " сек. " + ts.Milliseconds + " мс. " + Environment.NewLine;

			//long unixTimestamp = (long)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalMilliseconds;
			//textBox2.Text += unixTimestamp;

			//long timestamp = (long)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalMilliseconds;
			//string address = "symbol=" + "ETHBTC" + "&timestamp=" + timestamp;
			//string signature = HmacSha256Digest(address, Request.SecretAPIkey);
			//address = address + "&signature=" + signature;

			//string line = Request.Do_withAPIkey("https://api.binance.com/api/v3/allOrders" + "?" + address, "GET");
			//textBox1.Text = "";
			//if (line == "[]")
			//	textBox1.Text = "Нет сделок с данной парой";
			//else
			//{
			//	textBox1.Text = line;
			//}
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
		private void OrderBookStartButton_Click(object sender, EventArgs e)
		{
			OrderBook form = new OrderBook();
			form.Show();
		}

		private void SymbolsPriceTickerStartButton_Click(object sender, EventArgs e)
		{
			SymbolsPriceTicker form = new SymbolsPriceTicker();
			form.Show();
		}

		private void NewOrderButton_Click(object sender, EventArgs e)
		{
			NewOrder form = new NewOrder();
			form.Show();
		}

		private void APIkeysStartButton_Click(object sender, EventArgs e)
		{
			APIkeys form = new APIkeys();
			if (form.ShowDialog() == DialogResult.OK)
			{
				//NewOrderButton.Enabled = true;
				AccountStartButton.Enabled = true;
				OrdersStartButton.Enabled = true;
			}
		}

		private void AccountStartButton_Click(object sender, EventArgs e)
		{
			Account form = new Account();
			form.Show();
		}

		private void OrdersStartButton_Click(object sender, EventArgs e)
		{
			Orders form = new Orders();
			form.Show();
		}
	}
}
