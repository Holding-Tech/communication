using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Model
{
    public class Communication
    {
        public int message_id { get; set; }

        public int sender_id { get; set; }

        public int reciever { get; set; }

        public string Message_content { get; set; }

        public DateTime Sent_date { get; set; }
    }
}