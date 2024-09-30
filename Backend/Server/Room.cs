using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class Room
    {
        // Properties
        public string RoomId { get; private set; }
        public List<string> Players { get; private set; }
        public bool IsPrivate { get; private set; }
        private const int MaxPlayers = 2;

        // Constructor
        public Room(string roomId, string player1, bool isPrivate)
        {
            RoomId = roomId;
            Players = new List<string> { player1 };
            IsPrivate = isPrivate;
        }

        // Method to add player to the room
        public bool AddPlayer(string player)
        {
            if (Players.Count < MaxPlayers)
            {
                Players.Add(player);
                return true; // Player added successfully
            }
            return false; // Room is full
        }

        // Method to check if room is full
        public bool IsFull()
        {
            return Players.Count >= MaxPlayers;
        }

        // Optional: Method to remove player from the room
        public void RemovePlayer(string player)
        {
            Players.Remove(player);
        }

        // Optional: Method to get room info
        public string GetRoomInfo()
        {
            return $"Room ID: {RoomId}, Players: {string.Join(", ", Players)}, Is Private: {IsPrivate}";
        }
    }
}
