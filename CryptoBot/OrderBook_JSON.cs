using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoBot
{
	class OrderBook_JSON
	{
		public int lastUpdateId { get; set; }
		public List<List<object>> bids { get; set; }
		public List<List<object>> asks { get; set; }
	}
}
