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
    public partial class SelectGame : Form
    {
        public SelectGame()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EnterPlayers Singleplayer = new EnterPlayers();
            this.Hide();
            Singleplayer.SetSinglePlayer();
            Singleplayer.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EnterPlayers Multiplayer = new EnterPlayers();
            this.Hide();
            Multiplayer.ShowDialog();
        }
    }
}
