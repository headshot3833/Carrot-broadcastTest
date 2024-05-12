using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Carrot_broadcast.Parser.Models
{
    public class ModelResult
    {
        public ModelName Name { get; set; }
        public string Email { get; set; }
        public ModelLocation Location { get; set; }
    }
}
