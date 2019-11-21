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
	public partial class OrderBook : Form
	{
		string[] symbols = { "ETHBTC", "LTCBTC", "BNBBTC", "NEOBTC", "123456", "QTUMETH", "EOSETH", "SNTETH", "BNTETH", "BCCBTC", "GASBTC", "BNBETH", "BTCUSDT", "ETHUSDT", "HSRBTC", "OAXETH", "DNTETH", "MCOETH", "ICNETH", "MCOBTC", "WTCBTC", "WTCETH", "LRCBTC", "LRCETH", "QTUMBTC", "YOYOBTC", "OMGBTC", "OMGETH", "ZRXBTC", "ZRXETH", "STRATBTC", "STRATETH", "SNGLSBTC", "SNGLSETH", "BQXBTC", "BQXETH", "KNCBTC", "KNCETH", "FUNBTC", "FUNETH", "SNMBTC", "SNMETH", "NEOETH", "IOTABTC", "IOTAETH", "LINKBTC", "LINKETH", "XVGBTC", "XVGETH", "CTRBTC", "CTRETH", "SALTBTC", "SALTETH", "MDABTC", "MDAETH", "MTLBTC", "MTLETH", "SUBBTC", "SUBETH", "EOSBTC", "SNTBTC", "ETCETH", "ETCBTC", "MTHBTC", "MTHETH", "ENGBTC", "ENGETH", "DNTBTC", "ZECBTC", "ZECETH", "BNTBTC", "ASTBTC", "ASTETH", "DASHBTC", "DASHETH", "OAXBTC", "ICNBTC", "BTGBTC", "BTGETH", "EVXBTC", "EVXETH", "REQBTC", "REQETH", "VIBBTC", "VIBETH", "HSRETH", "TRXBTC", "TRXETH", "POWRBTC", "POWRETH", "ARKBTC", "ARKETH", "YOYOETH", "XRPBTC", "XRPETH", "MODBTC", "MODETH", "ENJBTC", "ENJETH", "STORJBTC", "STORJETH", "BNBUSDT", "VENBNB", "YOYOBNB", "POWRBNB", "VENBTC", "VENETH", "KMDBTC", "KMDETH", "NULSBNB", "RCNBTC", "RCNETH", "RCNBNB", "NULSBTC", "NULSETH", "RDNBTC", "RDNETH", "RDNBNB", "XMRBTC", "XMRETH", "DLTBNB", "WTCBNB", "DLTBTC", "DLTETH", "AMBBTC", "AMBETH", "AMBBNB", "BCCETH", "BCCUSDT", "BCCBNB", "BATBTC", "BATETH", "BATBNB", "BCPTBTC", "BCPTETH", "BCPTBNB", "ARNBTC", "ARNETH", "GVTBTC", "GVTETH", "CDTBTC", "CDTETH", "GXSBTC", "GXSETH", "NEOUSDT", "NEOBNB", "POEBTC", "POEETH", "QSPBTC", "QSPETH", "QSPBNB", "BTSBTC", "BTSETH", "BTSBNB", "XZCBTC", "XZCETH", "XZCBNB", "LSKBTC", "LSKETH", "LSKBNB", "TNTBTC", "TNTETH", "FUELBTC", "FUELETH", "MANABTC", "MANAETH", "BCDBTC", "BCDETH", "DGDBTC", "DGDETH", "IOTABNB", "ADXBTC", "ADXETH", "ADXBNB", "ADABTC", "ADAETH", "PPTBTC", "PPTETH", "CMTBTC", "CMTETH", "CMTBNB", "XLMBTC", "XLMETH", "XLMBNB", "CNDBTC", "CNDETH", "CNDBNB", "LENDBTC", "LENDETH", "WABIBTC", "WABIETH", "WABIBNB", "LTCETH", "LTCUSDT", "LTCBNB", "TNBBTC", "TNBETH", "WAVESBTC", "WAVESETH", "WAVESBNB", "GTOBTC", "GTOETH", "GTOBNB", "ICXBTC", "ICXETH", "ICXBNB", "OSTBTC", "OSTETH", "OSTBNB", "ELFBTC", "ELFETH", "AIONBTC", "AIONETH", "AIONBNB", "NEBLBTC", "NEBLETH", "NEBLBNB", "BRDBTC", "BRDETH", "BRDBNB", "MCOBNB", "EDOBTC", "EDOETH", "WINGSBTC", "WINGSETH", "NAVBTC", "NAVETH", "NAVBNB", "LUNBTC", "LUNETH", "TRIGBTC", "TRIGETH", "TRIGBNB", "APPCBTC", "APPCETH", "APPCBNB", "VIBEBTC", "VIBEETH", "RLCBTC", "RLCETH", "RLCBNB", "INSBTC", "INSETH", "PIVXBTC", "PIVXETH", "PIVXBNB" };
		public OrderBook()
		{
			InitializeComponent();
			comboBox1.Items.AddRange(symbols);
			OKbutton.Enabled = false;
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			if (textBox1.Text == "" || comboBox1.SelectedItem.ToString() == "")
				OKbutton.Enabled = false;
			else
				OKbutton.Enabled = true;
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (textBox1.Text == "" || comboBox1.SelectedItem.ToString() == "")
				OKbutton.Enabled = false;
			else
				OKbutton.Enabled = true;
		}
		private void OKbutton_Click(object sender, EventArgs e)
		{
			string line = Request.Do("https://www.binance.com/api/v1/depth" + "?" + "symbol=" + comboBox1.SelectedItem.ToString() + "&limit=" + textBox1.Text);
			OrderBook_JSON OrderBook = JsonConvert.DeserializeObject<OrderBook_JSON>(line);
			textBox2.Text = "";
			textBox2.Text += "Время обновления: " + OrderBook.lastUpdateId + Environment.NewLine;
			textBox2.Text += "Предложения:" + Environment.NewLine;
			textBox2.Text += "\tЦена                       Количество" + Environment.NewLine;
			for (int i = 0; i < OrderBook.bids.Count; i++)
			{
				textBox2.Text += "\t" + OrderBook.bids[i][0] + "\t" + OrderBook.bids[i][1] + Environment.NewLine;
			}

			textBox2.Text += "Запросы:" + Environment.NewLine;
			textBox2.Text += "\tЦена                       Количество" + Environment.NewLine;
			for (int i = 0; i < OrderBook.asks.Count; i++)
			{
				textBox2.Text += "\t" + OrderBook.asks[i][0] + "\t" + OrderBook.asks[i][1] + Environment.NewLine;
			}
		}
	}
}
