using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoBot
{
	class AccountInformation_JSON
	{
		public int makerCommission { get; set; }
		public int takerCommission { get; set; }
		public int buyerCommission { get; set; }
		public int sellerCommission { get; set; }
		public bool canTrade { get; set; }
		public bool canWithdraw { get; set; }
		public bool canDeposit { get; set; }
		public long updateTime { get; set; }
		public List<Balance> balances { get; set; }
	}
	class Balance
	{
		public string asset { get; set; }
		public string free { get; set; }
		public string locked { get; set; }
	}
}
