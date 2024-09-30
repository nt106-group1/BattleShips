using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Server
{
    class Program
    {
        private static RoomManager roomManager = new RoomManager();

        [STAThread]
        static void Main(string[] args)
        {
            // Khởi chạy server TCP
            Thread serverThread = new Thread(StartServer);
            serverThread.Start();

            // Giữ server hoạt động bằng cách đợi người dùng nhấn Enter
            Console.WriteLine("Server is running. Press Enter to stop.");
            Console.ReadLine();  // Chờ nhập từ người dùng để dừng server
        }

        public static void StartServer()
        {
            try
            {
                IPAddress ipAddress = IPAddress.Any;  // Lắng nghe tất cả các IP
                int port = 8080;  // Port để lắng nghe
                TcpListener listener = new TcpListener(ipAddress, port);
                listener.Start();
                Console.WriteLine("Server đang chạy tại IP: {0} trên port {1}. Đang chờ kết nối...", ipAddress, port);

                while (true)
                {
                    TcpClient client = listener.AcceptTcpClient();  // Chấp nhận kết nối từ client
                    Console.WriteLine("Client đã kết nối.");
                    Thread clientThread = new Thread(() => HandleClient(client));  // Xử lý client trên thread riêng
                    clientThread.Start();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi khởi chạy server: " + ex.Message);
            }
        }

        public static void HandleClient(TcpClient client)
        {
            NetworkStream stream = null;
            try
            {
                stream = client.GetStream();
                byte[] buffer = new byte[1024];
                int byteCount;

                while ((byteCount = stream.Read(buffer, 0, buffer.Length)) != 0)
                {
                    // Đọc dữ liệu từ client
                    string request = Encoding.UTF8.GetString(buffer, 0, byteCount);
                    Console.WriteLine("Nhận yêu cầu: " + request);

                    string response = ProcessRequest(request);  // Xử lý yêu cầu từ client
                    byte[] responseData = Encoding.UTF8.GetBytes(response);

                    stream.Write(responseData, 0, responseData.Length);  // Gửi phản hồi lại client
                    Console.WriteLine("Gửi phản hồi: " + response);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi xử lý client: " + ex.Message);
            }
            finally
            {
                if (stream != null)
                    stream.Close();
                client.Close();
                Console.WriteLine("Client đã ngắt kết nối.");
            }
        }

        // Hàm xử lý yêu cầu từ client
        public static string ProcessRequest(string request)
        {
            try
            {
                string[] requestData = request.Split(':');
                string command = requestData[0];
                string player = requestData[1];

                if (command == "CreateRoom")
                {
                    bool isPrivate = bool.Parse(requestData[2]);
                    string roomId = roomManager.CreateRoom(player, isPrivate);
                    return "RoomID:" + roomId;
                }
                else if (command == "JoinRoom")
                {
                    string roomId = requestData[2];
                    string result = roomManager.JoinRoom(roomId, player);
                    return result;
                }

                return "Invalid request format";
            }
            catch (Exception ex)
            {
                return "Error processing request: " + ex.Message;
            }
        }
    }
}
