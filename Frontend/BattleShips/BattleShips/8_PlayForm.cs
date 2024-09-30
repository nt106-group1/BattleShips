using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace BattleShips
{
    public partial class PlayForm : Form
    {
        public PlayForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Private_Public formCreateRoom = new Private_Public();
            formCreateRoom.Show();
            this.Close();
        }

        private void DisplayPlayerName()
        {
            if (!string.IsNullOrEmpty(NamingForm.PlayerName))
            {
                lbMyName.Text = $"Người chơi: {NamingForm.PlayerName}";
            }
        }
    }
}
