using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaizenCase.Models
{
    public class Vertice
    {
        [JsonProperty("x")]
        public int XPos { get; set; }
        [JsonProperty("y")]
        public int YPos { get; set; }
    }
}
