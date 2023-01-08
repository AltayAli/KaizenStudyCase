using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaizenCase.Models
{
    public class Response 
    {
        public string Locale { get; set; }
        public string Description { get; set; }
        public BoundingPoly BoundingPoly { get; set; }

    }
}
