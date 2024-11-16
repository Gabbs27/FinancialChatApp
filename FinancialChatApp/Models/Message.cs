using System;
using System.ComponentModel.DataAnnotations;

namespace FinancialChatApp.Data
{
    public class Message
    {
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; } // From Identity

        [Required]
        public string Content { get; set; }

        public DateTime Timestamp { get; set; } = DateTime.UtcNow;

        public int ChatRoomId { get; set; } // Foreign Key
    }
}