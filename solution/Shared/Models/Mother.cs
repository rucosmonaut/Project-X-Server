using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Models
{
    public enum MotherTypes
    {
        Nataly
    }

    public class Mother
    {
        public int MotherId { get; set; }
        public string Name { get; set; }
        public string RussianName { get; set; }

        public Mother(string name, string russianName)
        {
            Name = name;
            RussianName = russianName;
        }

        public static readonly Dictionary<MotherTypes, Mother> Fathers = new Dictionary<MotherTypes, Mother>
        {
            { MotherTypes.Nataly, new Mother("Nataly", "Натали") }
        };

    }
}
