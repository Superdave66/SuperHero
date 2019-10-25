using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HeroMaker.Models
{
    public class Hero
    {
        [key]
        public int HeroID { get; set; }
        public string HeroName { get; set; }
        public string HeroAlias { get; set; }
        public string MainSuperPower { get; set; }
        public string SecondarySuperPower{ get; set; }
        public string Catchphrase{ get; set; }

    }
}