namespace WebApplication1.Controllers
{
    public class Communication
    {
        public int message_id { get; set; }

        public int sender_id { get; set; }

        public int reciever { get; set; }

        public string message_content { get; set; }
        
        public dateTime sent_date {get; set; }
    }
}