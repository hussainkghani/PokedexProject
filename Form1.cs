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
using pokemonDLL;


namespace PokedexProject
{
    public partial class Login : Form
    {
        PokeRepository repository; //create instance of repository 
        public Login()
        {
            InitializeComponent();
            repository = new PokeRepository(); //initialize repository 
           
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userid = txtuserName.Text; //User login fields
            string password = txtPassword.Text;
            if (string.IsNullOrEmpty(txtuserName.Text) && string.IsNullOrEmpty(txtPassword.Text)) //if login fields are empty
            {
                richtxtMessage.ForeColor = Color.Red;
                richtxtMessage.Text = "Need Login and Password";
            }
            else //if login fields is not empty
            {
                if (repository.Login(userid, password)) //if login details match the Login method in Pokemon.dll
                {
                    richtxtMessage.ForeColor = Color.Green;
                    richtxtMessage.Text = "Welcome Professor!";
                    WaitOneSec(); //method for opening next window with .5s delay
                }
                else
                {
                    richtxtMessage.Text = "Reenter Login";
                }
            }             
        }
        private void WaitOneSec()
        {
            DisplayPokemon displayPokemon = new DisplayPokemon();
            Thread.Sleep(500);
            displayPokemon.Show();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
