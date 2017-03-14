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
using AlchymyShoppe.Models;


namespace AlchymyShoppe.Controls
{
    /// <summary>
    /// Interaction logic for PotionIngredientBox.xaml
    /// </summary>
    public partial class PotionIngredientBox : UserControl
    {
        private Ingredient craftingIngedient = new Ingredient("None", System.IO.Directory.GetCurrentDirectory() + "Images/Sprites/alchemy.png", 0, Rarity.None, AlchymicEffect.None);
        public Ingredient CraftingIngredient
        {
            get
            {
                return craftingIngedient;
            }
            set
            {
                craftingIngedient = value;
                LoadImage();
            }
        }

        private void LoadImage()
        {
            if(craftingIngedient != null)
            {
                LoadIngredientImage();
            }
            else
            {
                UnloadIngredientImage();
            }
        }

        public PotionIngredientBox()
        {
            InitializeComponent();
            imgIngredientBackground.Source = ImageUtil.BitmapToImageSource(Resoures.emptyBoxFiller_800x800);
        }

        public void LoadIngredient(Ingredient ingredient)
        {
            craftingIngedient = ingredient;
        }

        public void LoadIngredientImage()
        {
            if(craftingIngedient.name.Equals("archane.png"))
            {
                imgIngredient.Source = ImageUtil.BitmapToImageSource(Resoures.archane);
            } else if(craftingIngedient.name.Equals("beast.png"))
            {
                imgIngredient.Source = ImageUtil.BitmapToImageSource(Resoures.beast);
            } else if(craftingIngedient.name.Equals("cloth.png"))
            {
                imgIngredient.Source = ImageUtil.BitmapToImageSource(Resoures.cloth);
            } else if(craftingIngedient.name.Equals("eagleegg.png"))
            {
                imgIngredient.Source = ImageUtil.BitmapToImageSource(Resoures.eagleegg);
            } else if(craftingIngedient.name.Equals("feather.png"))
            {
                imgIngredient.Source = ImageUtil.BitmapToImageSource(Resoures.feather);
            } else if(craftingIngedient.name.Equals("fish.png"))
            {
                imgIngredient.Source = ImageUtil.BitmapToImageSource(Resoures.fish);
            } else if(craftingIngedient.name.Equals("humanoid.png"))
            {
                imgIngredient.Source = ImageUtil.BitmapToImageSource(Resoures.humanoid);
            } else if(craftingIngedient.name.Equals("insect.png"))
            {
                imgIngredient.Source = ImageUtil.BitmapToImageSource(Resoures.insect);
            } else if(craftingIngedient.name.Equals("liquid.png"))
            {
                imgIngredient.Source = ImageUtil.BitmapToImageSource(Resoures.liquid);
            } else if(craftingIngedient.name.Equals("plant.png"))
            {
                imgIngredient.Source = ImageUtil.BitmapToImageSource(Resoures.plant);
            } else if(craftingIngedient.name.Equals("powder.png"))
            {
                imgIngredient.Source = ImageUtil.BitmapToImageSource(Resoures.powder);
            } else if(craftingIngedient.name.Equals("raven.png"))
            {
                imgIngredient.Source = ImageUtil.BitmapToImageSource(Resoures.raven);
            } else if(craftingIngedient.name.Equals("reptile.png"))
            {
                imgIngredient.Source = ImageUtil.BitmapToImageSource(Resoures.reptile);
            }
            imgIngredient.Source = ImageUtil.BitmapToImageSource(Resoures.alchemy);
        }

        public void UnloadIngredientImage()
        {
            imgIngredient.Source = null;
        }
    }
}
