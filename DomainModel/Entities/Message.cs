using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Entities
{
    public class Message : EntityBase
    {
        private string v1;
        private string v2;
        private string v3;
        private string v4;

        public virtual User Sender { get; set; }
        public virtual User Recipient { get; set; }
        public DateTime DateTimeSent { get; set; }
        public string Content { get; set; }

        public Message(User sender, User recipient, DateTime date_time_sent, string content)
        {
            Sender = sender;
            Recipient = recipient;
            DateTimeSent = date_time_sent;
            Content = content;
        }

        public Message(string v1, string v2, string v3, string v4)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
        }
    }


}
