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
	public partial class Orders : Form
	{
		string[] symbols = { "ETHBTC", "LTCBTC", "BNBBTC", "NEOBTC", "123456", "QTUMETH", "EOSETH", "SNTETH", "BNTETH", "BCCBTC", "GASBTC", "BNBETH", "BTCUSDT", "ETHUSDT", "HSRBTC", "OAXETH", "DNTETH", "MCOETH", "ICNETH", "MCOBTC", "WTCBTC", "WTCETH", "LRCBTC", "LRCETH", "QTUMBTC", "YOYOBTC", "OMGBTC", "OMGETH", "ZRXBTC", "ZRXETH", "STRATBTC", "STRATETH", "SNGLSBTC", "SNGLSETH", "BQXBTC", "BQXETH", "KNCBTC", "KNCETH", "FUNBTC", "FUNETH", "SNMBTC", "SNMETH", "NEOETH", "IOTABTC", "IOTAETH", "LINKBTC", "LINKETH", "XVGBTC", "XVGETH", "CTRBTC", "CTRETH", "SALTBTC", "SALTETH", "MDABTC", "MDAETH", "MTLBTC", "MTLETH", "SUBBTC", "SUBETH", "EOSBTC", "SNTBTC", "ETCETH", "ETCBTC", "MTHBTC", "MTHETH", "ENGBTC", "ENGETH", "DNTBTC", "ZECBTC", "ZECETH", "BNTBTC", "ASTBTC", "ASTETH", "DASHBTC", "DASHETH", "OAXBTC", "ICNBTC", "BTGBTC", "BTGETH", "EVXBTC", "EVXETH", "REQBTC", "REQETH", "VIBBTC", "VIBETH", "HSRETH", "TRXBTC", "TRXETH", "POWRBTC", "POWRETH", "ARKBTC", "ARKETH", "YOYOETH", "XRPBTC", "XRPETH", "MODBTC", "MODETH", "ENJBTC", "ENJETH", "STORJBTC", "STORJETH", "BNBUSDT", "VENBNB", "YOYOBNB", "POWRBNB", "VENBTC", "VENETH", "KMDBTC", "KMDETH", "NULSBNB", "RCNBTC", "RCNETH", "RCNBNB", "NULSBTC", "NULSETH", "RDNBTC", "RDNETH", "RDNBNB", "XMRBTC", "XMRETH", "DLTBNB", "WTCBNB", "DLTBTC", "DLTETH", "AMBBTC", "AMBETH", "AMBBNB", "BCCETH", "BCCUSDT", "BCCBNB", "BATBTC", "BATETH", "BATBNB", "BCPTBTC", "BCPTETH", "BCPTBNB", "ARNBTC", "ARNETH", "GVTBTC", "GVTETH", "CDTBTC", "CDTETH", "GXSBTC", "GXSETH", "NEOUSDT", "NEOBNB", "POEBTC", "POEETH", "QSPBTC", "QSPETH", "QSPBNB", "BTSBTC", "BTSETH", "BTSBNB", "XZCBTC", "XZCETH", "XZCBNB", "LSKBTC", "LSKETH", "LSKBNB", "TNTBTC", "TNTETH", "FUELBTC", "FUELETH", "MANABTC", "MANAETH", "BCDBTC", "BCDETH", "DGDBTC", "DGDETH", "IOTABNB", "ADXBTC", "ADXETH", "ADXBNB", "ADABTC", "ADAETH", "PPTBTC", "PPTETH", "CMTBTC", "CMTETH", "CMTBNB", "XLMBTC", "XLMETH", "XLMBNB", "CNDBTC", "CNDETH", "CNDBNB", "LENDBTC", "LENDETH", "WABIBTC", "WABIETH", "WABIBNB", "LTCETH", "LTCUSDT", "LTCBNB", "TNBBTC", "TNBETH", "WAVESBTC", "WAVESETH", "WAVESBNB", "GTOBTC", "GTOETH", "GTOBNB", "ICXBTC", "ICXETH", "ICXBNB", "OSTBTC", "OSTETH", "OSTBNB", "ELFBTC", "ELFETH", "AIONBTC", "AIONETH", "AIONBNB", "NEBLBTC", "NEBLETH", "NEBLBNB", "BRDBTC", "BRDETH", "BRDBNB", "MCOBNB", "EDOBTC", "EDOETH", "WINGSBTC", "WINGSETH", "NAVBTC", "NAVETH", "NAVBNB", "LUNBTC", "LUNETH", "TRIGBTC", "TRIGETH", "TRIGBNB", "APPCBTC", "APPCETH", "APPCBNB", "VIBEBTC", "VIBEETH", "RLCBTC", "RLCETH", "RLCBNB", "INSBTC", "INSETH", "PIVXBTC", "PIVXETH", "PIVXBNB" };
		string OpenOrders = "https://api.binance.com/api/v3/openOrders";
		string AllOrders = "https://api.binance.com/api/v3/allOrders";
		string QueryCancelOrder = "https://api.binance.com/api/v3/order";
		List<Order_JSON> OrdersList = new List<Order_JSON>();
		public Orders()
		{
			InitializeComponent();
			SymbolChoiceComboBox.Items.AddRange(symbols);
			SymbolChoiceComboBox.SelectedIndex = 0;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			CheckedChanged(sender, e);
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

		private void CheckedChanged(object sender, EventArgs e)
		{
			long timestamp = (long)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalMilliseconds;
			string address = "symbol=" + SymbolChoiceComboBox.SelectedItem.ToString() + "&timestamp=" + timestamp;
			string signature = HmacSha256Digest(address, Request.SecretAPIkey);
			address = address + "&signature=" + signature;

			string line = Request.Do_withAPIkey((CurrentOrdersRadioButton.Checked ? OpenOrders : AllOrders) + "?" + address, "GET");
			textBox1.Text = "";
			OrdersListBox.Items.Clear();
			if (line == "[]")
				textBox1.Text = "Ордеров с данной парой не было";
			else
			{
				List<string> stringOrders = SplitRecords(line);
				OrdersList.Clear();
				foreach (string s in stringOrders)
					OrdersList.Add(JsonConvert.DeserializeObject<Order_JSON>(s));
				foreach (Order_JSON order in OrdersList)
					OrdersListBox.Items.Add(order.orderId);
			}

			OrdersListBox_SelectedIndexChanged(sender, e);
		}

		private void OrdersListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (OrdersListBox.SelectedIndex != -1)
			{
				QueryOrderStartButton.Enabled = true;
				if (CurrentOrdersRadioButton.Checked)
				{
					CancelOrderStartButton.Enabled = true;
				}
				Order_JSON order = OrdersList[OrdersListBox.SelectedIndex];
				ShowOrder(order);
			}
			else
			{
				textBox1.Clear();
				QueryOrderStartButton.Enabled = false;
				CancelOrderStartButton.Enabled = false;
			}
		}

		private void QueryOrderStartButton_Click(object sender, EventArgs e)
		{
			long timestamp = (long)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalMilliseconds;
			string address = "symbol=" + SymbolChoiceComboBox.SelectedItem.ToString() + "&orderId=" 
				+ OrdersListBox.SelectedItem.ToString() + "&timestamp=" + timestamp;
			string signature = HmacSha256Digest(address, Request.SecretAPIkey);
			address = address + "&signature=" + signature;

			string line = Request.Do_withAPIkey(QueryCancelOrder + "?" + address, "GET");
			Order_JSON order = JsonConvert.DeserializeObject<Order_JSON>(line);
			OrdersList[OrdersListBox.SelectedIndex] = order;
			ShowOrder(order);
		}
		void ShowOrder(Order_JSON order)
		{
			textBox1.Clear();
			textBox1.Text += "id: " + order.orderId + Environment.NewLine;
			textBox1.Text += "Пара: " + order.symbol + Environment.NewLine;
			//textBox1.Text += "clientOrderId: " + order.clientOrderId + Environment.NewLine;
			textBox1.Text += "Цена: " + order.price + Environment.NewLine;
			textBox1.Text += "Количество: " + order.origQty + Environment.NewLine;
			textBox1.Text += "Обработано: " + order.executedQty + Environment.NewLine;
			textBox1.Text += "Статус: " + order.status + Environment.NewLine;
			textBox1.Text += "Время действия: " + order.timeInForce + Environment.NewLine;
			textBox1.Text += "Тип: " + order.type + Environment.NewLine;
			textBox1.Text += "Тип: " + (order.side == "BUY" ? "Покупка" : "Продажа") + Environment.NewLine;
			textBox1.Text += "stopPrice: " + order.stopPrice + Environment.NewLine;
			textBox1.Text += "icebergQty: " + order.icebergQty + Environment.NewLine;
			textBox1.Text += "Время: " + order.time + Environment.NewLine;
			textBox1.Text += "isWorking: " + (order.isWorking ? "Да" : "Нет") + Environment.NewLine;
		}

		private void CancelOrderStartButton_Click(object sender, EventArgs e)
		{
			long timestamp = (long)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalMilliseconds;
			string address = "symbol=" + SymbolChoiceComboBox.SelectedItem.ToString() + "&orderId="
				+ OrdersListBox.SelectedItem.ToString() + "&timestamp=" + timestamp;
			string signature = HmacSha256Digest(address, Request.SecretAPIkey);
			address = address + "&signature=" + signature;

			string line = Request.Do_withAPIkey(QueryCancelOrder + "?" + address, "DELETE");

			CheckedChanged(sender, e);
			//textBox1.Text = line;
			//Order_JSON order = JsonConvert.DeserializeObject<Order_JSON>(line);
			//OrdersList[OrdersListBox.SelectedIndex] = order;
			//ShowOrder(order);
		}

		private void NewOrderStartButton_Click(object sender, EventArgs e)
		{
			NewOrder form = new NewOrder();
			form.Show();
		}
	}
}
