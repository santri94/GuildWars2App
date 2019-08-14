using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gw2
{
    public class Character
    {
        public string name { get; set; }
        public string race { get; set; }
        public string profession { get; set; }
        //public string equipment { get; set; }
        public List<Items> equipment;
    }
}
