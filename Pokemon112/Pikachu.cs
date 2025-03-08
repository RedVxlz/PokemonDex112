﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using Pokemon112;

namespace Pokemon112
{
    //inheritance from the Pokemon class
    public class Pikachu : Pokemon
    {
        //constructor
        //run at first when the object is created
        public Pikachu()
        {
            this.Type = PokemonType.electric;
            this.Height = 0.4;
            this.Weight = 6.0;
            this.HP = 35;
            this.Attack = 55;
            this.Defense = 40;
            this.SpecialAttack = 50;
            this.SpecialDefense = 50;
            this.Speed = 90;
            this.Total = 320;
            this.Name = "Pikachu";
            //check if the image in ResourceManager is not null
            //return the image
            var imageObject = Resourcepokemon.ResourceManager.GetObject("pikachu");
            if (imageObject != null)
            {
                this.image = (byte[])imageObject;
            }
            else
            {
                this.image = Array.Empty<byte>();
            }
        }
    }
}
