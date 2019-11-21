using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoBot
{
	class NewOrder_JSON
	{
		public string symbol { get; set; }
		public int orderId { get; set; }
		public string clientOrderId { get; set; }
		public long transactTime { get; set; }
	}
}
