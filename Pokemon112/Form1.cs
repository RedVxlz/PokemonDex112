using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon112
{
    public partial class Form1: Form
    {
        private List<Pokemon> pokemonsList = new List<Pokemon>();
        public Form1()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form1_Load);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Pokemon pikachu = new Pikachu();
            Pokemon charmeleon = new Charmeleon();
            Pokemon nidorina = new Nidorina();
            Pokemon sandslash = new Sandslash();
            Pokemon snorlax = new Snorlax();
            Pokemon clefairy = new Clefairy();

            this.pokemonsList.Add(pikachu);
            this.pokemonsList.Add(charmeleon);
            this.pokemonsList.Add(nidorina);
            this.pokemonsList.Add(sandslash);
            this.pokemonsList.Add(snorlax);
            this.pokemonsList.Add(clefairy);

            this.DisplayPokemon(pikachu);
        }
        private void DisplayPokemon(Pokemon pokemon)
        {
            lbPokemonName.Text = pokemon.GetName();
            label1.Text = pokemon.GetName();
            label2.Text = pokemon.GetType().ToString();
            label3.Text = pokemon.GetHeight().ToString();
            label4.Text = pokemon.GetWeight().ToString();
            label5.Text = pokemon.GetHP().ToString();
            label6.Text = pokemon.GetAttack().ToString();
            label7.Text = pokemon.GetDefense().ToString();
            label8.Text = pokemon.GetTotal().ToString();

            if (pokemon.GetImage() != null && pokemon.GetImage().Length > 0)
            {
                using (var ms = new MemoryStream(pokemon.GetImage()))
                {
                    pictureBox1.Image = Image.FromStream(ms);
                }
            }
            else
            {
                pictureBox1.ImageLocation = pokemon.ImagePath;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DisplayPokemon(pokemonsList[0]);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DisplayPokemon(pokemonsList[1]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DisplayPokemon(pokemonsList[2]);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DisplayPokemon(pokemonsList[3]);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DisplayPokemon(pokemonsList[4]);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DisplayPokemon(pokemonsList[5]);
        }
        private void labelDefense_Click(object sender, EventArgs e)
        {

        }
    }
}
