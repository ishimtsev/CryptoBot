﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoBot
{
	class Order_JSON
	{
		public string symbol { get; set; }
		public int orderId { get; set; }
		public string clientOrderId { get; set; }
		public string price { get; set; }
		public string origQty { get; set; }
		public string executedQty { get; set; }
		public string status { get; set; }
		public string timeInForce { get; set; }
		public string type { get; set; }
		public string side { get; set; }
		public string stopPrice { get; set; }
		public string icebergQty { get; set; }
		public long time { get; set; }
		public bool isWorking { get; set; }
	}
}
