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
    public partial class RoomWaiting : Form
    {
        private string roomId;
        public RoomWaiting(string roomId)
        {
            InitializeComponent();
            this.roomId = roomId;  // Lưu trữ RoomID
            DisplayPlayerName();  // Hiển thị tên người chơi
            DisplayRoomID();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Private_Public formCreateRoom = new Private_Public();
            formCreateRoom.Show();
            this.Close();
        }

        private void btnReady_Click(object sender, EventArgs e)
        {
            ShipDeployment shipDeployment = new ShipDeployment();   
            shipDeployment.Show();

            this.Hide();
        }

        private void DisplayPlayerName()
        {
            if (!string.IsNullOrEmpty(NamingForm.PlayerName))
            {
                LbMe.Text = $"Người chơi: {NamingForm.PlayerName}";
            }
        }

        private void DisplayRoomID()
        {
            if (!string.IsNullOrEmpty(roomId))
            {
               label1.Text = $"Room ID: {roomId}";
            }
        }
    }
}
