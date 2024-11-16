using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FinancialChatApp.Data
{
    public class ChatRoom
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<Message> Messages { get; set; }
    }
}