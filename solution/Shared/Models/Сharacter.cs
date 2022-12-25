using Shared.Dictionaries;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Models
{
    public class Character
    {

        public Finances Finance { get; set; }
        public States State { get; set; }
        public List<Item> Inventory { get; set; }

        //Внешность
        public SexTypes Sex { get; set; }

        //Наследие - Heritage
        public Father Father { get; set; }
        public Mother Mother { get; set; }
        public float Appearance { get; set; }
        public float ColorSkin { get; set; }

        //Характеристики - Specifications
        public float Forehead { get; set; }
        public float Eyes { get; set; }
        public float Nose { get; set; }
        public float NoseProfile { get; set; }
        public float NoseTip { get; set; }
        public float Cheekbones { get; set; }
        public float Cheeks { get; set; }
        public float Lips { get; set; }
        public float Jaw { get; set; }
        public float ChinProfile { get; set; }
        public float ChinShape { get; set; }

        //Внешность - Appearance
        public float Hairstyles { get; set; }
        public float Brows { get; set; }
        public float SkinDefects { get; set; }
        public float SkinAging { get; set; }
        public float SkinType { get; set; }
        public float MolesAndFreckles { get; set; }
        public float SkinDamage { get; set; }
        public float EyeColor { get; set; }
        public float Makeup { get; set; }
        public float Blush { get; set; }
        public float Pomade { get; set; }

        //Одежда - Clothing
        public float ClothingStyle { get; set; }
        public float Costume { get; set; }
        public float Headress { get; set; }
        public float Glasses { get; set; }
    }
}
