using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Entities
{
    public class Match
    {
        public Guid Id { get; set; }
        public User FirstConfirmed { get; set; }
        public User SecondConfirmed { get; set; }
    }
}
