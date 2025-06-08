using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Model
{
    public class Communication
    {

        [Key]
        public int sender_id { get; set; }
        public int message_id { get; set; }
       

        public int reciever { get; set; }

        public string Message_content { get; set; }

        public DateTime Sent_date { get; set; }
    }
}