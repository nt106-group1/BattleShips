using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace BattleShips
{
    public partial class Private_Public : Form
    {
        public Private_Public()
        {
            InitializeComponent();
        }

        // Người dùng chọn tạo phòng private
        private void button1_Click(object sender, EventArgs e)
        {
            string playerName = "Player1";  // Tên của người dùng (có thể lấy từ input khác)
            string request = $"CreateRoom:{playerName}:true";  // true: tạo phòng private

            // Gửi yêu cầu lên server
            string response = Program.SendRequestToServer(request);

            // Kiểm tra phản hồi và hiển thị phòng mới
            if (response.StartsWith("RoomID:"))
            {
                string roomId = response.Split(':')[1];
                MessageBox.Show("Phòng private được tạo thành công với Room ID: " + roomId);

                // Chuyển sang form RoomWaiting và truyền RoomID
                RoomWaiting formPrivate = new RoomWaiting(roomId);
                formPrivate.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Lỗi khi tạo phòng: " + response);
            }
        }

        // Người dùng chọn tạo phòng public
        private void button2_Click(object sender, EventArgs e)
        {
            string playerName = "Player1";  // Tên của người dùng (có thể lấy từ input khác)
            string request = $"CreateRoom:{playerName}:false";  // false: tạo phòng public

            // Gửi yêu cầu lên server
            string response = Program.SendRequestToServer(request);

            // Kiểm tra phản hồi và hiển thị phòng mới
            if (response.StartsWith("RoomID:"))
            {
                string roomId = response.Split(':')[1];
                MessageBox.Show("Phòng public được tạo thành công với Room ID: " + roomId);

                // Chuyển sang form RoomWaiting và truyền RoomID
                RoomWaiting formPublic = new RoomWaiting(roomId);
                formPublic.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Lỗi khi tạo phòng: " + response);
            }
        }
    }
}