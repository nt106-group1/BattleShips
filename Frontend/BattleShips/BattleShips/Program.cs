using System.Net.Sockets;
using System.Text;

namespace BattleShips
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new ShipDeployment());
        }

        // Hàm SendRequestToServer để tất cả form đều có thể dùng
        public static string SendRequestToServer(string message)
        {
            try
            {
                string serverIp = "34.132.66.108";  // IP server
                int port = 8080;  // Cổng server

                // Tạo kết nối TCP với server
                using (TcpClient client = new TcpClient(serverIp, port))
                using (NetworkStream stream = client.GetStream())
                {
                    // Gửi dữ liệu yêu cầu lên server
                    byte[] data = Encoding.UTF8.GetBytes(message);
                    stream.Write(data, 0, data.Length);

                    // Đọc phản hồi từ server
                    byte[] buffer = new byte[1024];
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    string response = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                    return response;
                }
            }
            catch (Exception ex)
            {
                // Báo lỗi nếu kết nối thất bại
                MessageBox.Show("Lỗi kết nối tới server: " + ex.Message);
                return null;
            }
        }
    }
}