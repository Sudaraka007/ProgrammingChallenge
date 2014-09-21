using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramingChallege
{
    public partial class EnterPlayers : Form
    {
        
        private Player PlayerOne = new Player();
        private Player PlayerTwo = new Player();    
        //private bool Singleplayer = true;
        public EnterPlayers()
        {
            InitializeComponent();
        }
        public void SetSinglePlayer()
        {
            this.groupBox2.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm Gameform = new MainForm();
            PlayerOne.Name=txtPlayer1.Text;
            PlayerTwo.Name=txtPlayer2.Text;
            Gameform.Show();
        }
        
    }
    
}
