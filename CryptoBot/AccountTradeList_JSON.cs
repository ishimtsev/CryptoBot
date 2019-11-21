﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoBot
{
	class AccountTradeList_JSON
	{
		public int id { get; set; }
		public int orderId { get; set; }
		public string price { get; set; }
		public string qty { get; set; }
		public string commission { get; set; }
		public string commissionAsset { get; set; }
		public long time { get; set; }
		public bool isBuyer { get; set; }
		public bool isMaker { get; set; }
		public bool isBestMatch { get; set; }
	}
}
