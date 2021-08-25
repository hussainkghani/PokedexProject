using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Media;
using pokemonDLL;

namespace PokedexProject
{
    public partial class DisplayPokemon : Form
    {
        PokeRepository repository;
        decimal position; //position variable to be utilized later with the forward and back buttons
        public DisplayPokemon()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e) //implement logic where position should not be greater than 151 
        {
            position = position + 1; //based on current position, counter will go to next position in repository
            var pokemon = repository.SearchPokemon(position); //search function from interface based on the position given 
            txtName.Text = pokemon.Name;
            txtSpecies.Text = pokemon.Classification;
            txtTypeone.Text = pokemon.Type_1;
            txtTypetwo.Text = pokemon.Type_2;
            txtHeight.Text = pokemon.Height.ToString();  //remember to convert decimal to string
            txtWeight.Text = pokemon.Weight.ToString();  //remember to convert decimal to string
            richtxtDescription.Text = pokemon.Description;
            picBoxSprites.ImageLocation = pokemon.Picture;  //use the imagelocation function from the picture box to retrieve image path from database
            picBoxSprites.SizeMode = PictureBoxSizeMode.Zoom;
            SoundPlayer player = new SoundPlayer(); //add system.media to access sounds; soundplayer class controls playback of sound from .wav file
            player.SoundLocation = pokemon.Sound; //set location of sound source to database collumn
            player.Play(); //play sound from database source 

        }

        private void DisplayPokemon_Load(object sender, EventArgs e)
        {
            repository = new PokeRepository();
            position = 1; //indicates the starting position in the repository
            var pokemon = repository.SearchPokemon(1); //you are going to use the search feature from crud interface and point to the 1st position in database
            //Once you get the 1st position from the database, start assigning the respective collumn values to the textboxes
            txtName.Text = pokemon.Name;
            txtSpecies.Text = pokemon.Classification;
            txtTypeone.Text = pokemon.Type_1;
            txtTypetwo.Text = pokemon.Type_2;
            txtHeight.Text = pokemon.Height.ToString();  //remember to convert decimal to string
            txtWeight.Text = pokemon.Weight.ToString();  //remember to convert decimal to string
            richtxtDescription.Text = pokemon.Description;
            picBoxSprites.ImageLocation = pokemon.Picture;  //use the imagelocation function from the picture box to retrieve image path from database
            picBoxSprites.SizeMode = PictureBoxSizeMode.Zoom; //PictureboxSizeMode can be used to adjust the picture size
            SoundPlayer player = new SoundPlayer(); //add system.media to access sounds; soundplayer class controls playback of sound from .wav file
            player.SoundLocation = pokemon.Sound; //set location of sound source to database collumn
            player.Play(); //play sound from database source
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnBackwards_Click(object sender, EventArgs e) //handle exception where position should not be below 1
        {
            position = position - 1; //based on current position, counter will go back 1 in the repository
            var pokemon = repository.SearchPokemon(position);//search function from interface to indicate current position
            txtName.Text = pokemon.Name;
            txtSpecies.Text = pokemon.Classification;
            txtTypeone.Text = pokemon.Type_1;
            txtTypetwo.Text = pokemon.Type_2;
            txtHeight.Text = pokemon.Height.ToString();  //remember to convert decimal to string
            txtWeight.Text = pokemon.Weight.ToString();  //remember to convert decimal to string
            richtxtDescription.Text = pokemon.Description;
            picBoxSprites.ImageLocation = pokemon.Picture;  //use the imagelocation function from the picture box to retrieve image path from database
            picBoxSprites.SizeMode = PictureBoxSizeMode.Zoom;
            SoundPlayer player = new SoundPlayer(); //add system.media to access sounds; soundplayer class controls playback of sound from .wav file
            player.SoundLocation = pokemon.Sound; //set location of sound source to database collumn
            player.Play(); //play sound from database source 
        }

        private void btnSound_Click(object sender, EventArgs e)
        { 
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchToolStripMenuItem.Enabled = true;
        }

        private void byTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchPokemon searchPokemon = new SearchPokemon();
            Thread.Sleep(500);
            searchPokemon.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addNewPokemonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditPokemon editPokemon = new EditPokemon();
            Thread.Sleep(500);
            editPokemon.Show();
        }

        private void editPokemonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditPokemon editPokemon = new EditPokemon();
            Thread.Sleep(500);
            editPokemon.Show();
        }
    }
}
