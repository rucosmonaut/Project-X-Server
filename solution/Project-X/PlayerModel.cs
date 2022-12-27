using GTANetworkAPI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project_X
{
    public class PlayerModel : Player
    {
        public int AccountId { get; set; }
        public int CharacterId { get; set; }
        public int BankMoney { get; set; }
        public int CashMoney { get; set; }

        public PlayerModel(NetHandle netHandle) : base(netHandle)
        {
        }
    }
}
