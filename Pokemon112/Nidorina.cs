using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pokemon112.Properties;
using Pokemon112;

namespace Pokemon112
{
    public class Nidorina : Pokemon
    {
        //constructor
        //run at first when the object is created
        public Nidorina()
        {
            this.Type = PokemonType.poison;
            this.Height = 9.0;
            this.Weight = 56.2;
            this.HP = 60;
            this.Attack = 59;
            this.Defense = 40;
            this.SpecialAttack = 63;
            this.SpecialDefense = 40;
            this.Speed = 69;
            this.Total = 440;
            this.Name = "Nidorina";
            //check if the image in ResourceManager is not null
            //return the image
            var imageObject = Resourcepokemon.ResourceManager.GetObject("nidorina");
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
