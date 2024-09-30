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
    public partial class NamingForm : Form
    {
        public static string PlayerName;
        public NamingForm()
        {
            InitializeComponent();
        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
            this.Close();
        }

        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            PlayerName = txtName.Text;
            if (txtName.Text.Length == 0)
            {
                MessageBox.Show("Hãy nhập tên của bạn!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                CreateRoom formTaoPhong = new CreateRoom();
                formTaoPhong.Show();
                this.Hide();
            }
        }
    }
}
