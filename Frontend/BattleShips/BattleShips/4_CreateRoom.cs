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
    public partial class CreateRoom : Form
    {
        public CreateRoom()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Private_Public formPhong = new Private_Public();
            formPhong.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            NamingForm nameForm = new NamingForm();
            nameForm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string playerName = NamingForm.PlayerName;
            string roomId = textBox1.Text.Trim();
            if (string.IsNullOrEmpty(roomId))
            {
                MessageBox.Show("Vui lòng nhập Room ID.");
                return;
            }

            string request = $"JoinRoom:{playerName}:{roomId}";

            // Gọi hàm SendRequestToServer từ Program.cs
            string response = Program.SendRequestToServer(request);

            // Xử lý phản hồi từ server
            if (response == "Success")
            {
                // Tham gia phòng thành công, chuyển sang form RoomWaiting
                MessageBox.Show("Tham gia phòng thành công!");
                RoomWaiting roomWaiting = new RoomWaiting(roomId);  // Truyền RoomID vào form RoomWaiting
                roomWaiting.Show();
                this.Hide();
            }
            else if (response == "Room full")
            {
                MessageBox.Show("Phòng đã đầy. Không thể tham gia.");
            }
            else if (response == "Room does not exist")
            {
                MessageBox.Show("Phòng không tồn tại.");
            }
            else
            {
                MessageBox.Show("Lỗi không xác định: " + response);
            }
        }
    }
}
