using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleShips
{
    public partial class ShipDeployment : Form
    {
        public ShipDeployment()
        {
            InitializeComponent();
        }

        private void btnBackMenu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to left?", "Left this room?", MessageBoxButtons.OK, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                MenuForm menuForm = new MenuForm();
                menuForm.Show();

                this.Close();
            }

        }

        private void btnReady_Click(object sender, EventArgs e)
        {
            PlayForm playForm = new PlayForm();
            playForm.Show();
            this.Hide();
        }
    }
}
