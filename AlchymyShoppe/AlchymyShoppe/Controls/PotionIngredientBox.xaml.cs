﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AlchymyShoppe.Controls
{
    /// <summary>
    /// Interaction logic for PotionIngredientBox.xaml
    /// </summary>
    public partial class PotionIngredientBox : UserControl
    {
        private Ingredient craftingIngedient = new Ingredient("None", System.IO.Directory.GetCurrentDirectory() + "Images/Sprites/alchemy.png", 0, Rarity.None, AlchymicEffect.None);
        Ingredient CraftingIngredient
        {
            get
            {
                return craftingIngedient;
            }
            set
            {
                craftingIngedient = value;
            }
        }

        public PotionIngredientBox()
        {
            InitializeComponent();
        }

        public void LoadIngredientImage()
        {
            Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), CraftingIngredient.imagePath)));
        }
    }
}