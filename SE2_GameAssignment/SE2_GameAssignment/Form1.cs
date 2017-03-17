using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE2_GameAssignment
{
    public partial class GameGUI : Form
    {
        public GameGUI()
        {
            InitializeComponent();
            btnStartGame.Enabled = false;
            btnStartGame.Visible = false;
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            
            this.mapPanel.BackgroundImage = null;

        }

        private void nudAmountOfEnemies_ValueChanged(object sender, EventArgs e)
        {
            if (nudAmountOfEnemies.Value <= 0)
            {
                btnStartGame.Enabled = false;
                btnStartGame.Visible = false;
            }
            else
            {
                btnStartGame.Enabled = true;
                btnStartGame.Visible = true;
            }
        }
    }
}
