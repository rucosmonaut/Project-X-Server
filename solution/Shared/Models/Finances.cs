using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Finances
    {
        public int Bank { get; set; } = 5000;
        public int Cash { get; set; } = 500;

        public bool AddBank(int amount)
        {
            Bank += amount;
            return true;
        }

        public bool SubBank(int amount)
        {
            if (amount > Bank) return false;
            Bank -= amount;
            return true;
        }
    }
}
