﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlchymyShoppe
{
    public class Ingredient : AlchymicItem
    {
        public Ingredient(String name, String imagePath, int price, Rarity rarity, AlchymicEffect effects) : base(name, imagePath, price, rarity, effects){}
    }
}
