using Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class RoomManager
    {
        // Dictionary lưu trữ các phòng chơi (RoomID là key, Room là value)
        private Dictionary<string, Room> rooms = new Dictionary<string, Room>();

        // Tạo phòng mới
        public string CreateRoom(string player1, bool isPrivate)
        {
            string roomId = GenerateRoomID();  // Tạo RoomID ngẫu nhiên
            Room newRoom = new Room(roomId, player1, isPrivate);
            rooms.Add(roomId, newRoom);
            return roomId;
        }

        // Kiểm tra và cho phép người chơi tham gia phòng
        public string JoinRoom(string roomId, string player)
        {
            if (rooms.ContainsKey(roomId))
            {
                Room room = rooms[roomId];
                if (!room.IsFull())
                {
                    if (room.AddPlayer(player))
                    {
                        return "Success"; // Tham gia thành công
                    }
                }
                return "Room full"; // Phòng đã đầy
            }
            return "Room does not exist"; // Phòng không tồn tại
        }

        // Tạo RoomID ngẫu nhiên (6 ký tự)
        private string GenerateRoomID()
        {
            var random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 6)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
