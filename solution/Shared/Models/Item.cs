using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public enum ItemTypes
    {
        Drinks,
        Clothes,
        Keys,
    }

    public class Item
    {
        public ItemTypes Type { get; set; }
        public uint Count { get; set; }
        public uint MaxCount { get; set; }
    }
}
