using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrot_broadcast.Domain.Entity
{
    public class User
    {
        public int Id { get; set; }

        public string First { get; set; }

        public string Last { get; set; }

        public string Email { get; set; }

        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public DateTime Time { get; set; }
    }
}
