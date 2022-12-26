using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Models
{
    public enum FatherTypes
    {
        Benjamin
    }

    public class Father
    {
        public int FatherId { get; set; }
        public string Name { get; set; }
        public string RussianName { get; set; }

        public Father(string name, string russianName)
        {
            Name = name;
            RussianName = russianName;
        }

        public static readonly Dictionary<FatherTypes, Father> Fathers = new Dictionary<FatherTypes, Father>
        {
            { FatherTypes.Benjamin, new Father("Benjamin", "Бенджамин") }
        };

    }
}
