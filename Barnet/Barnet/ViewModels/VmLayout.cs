using Barnet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Barnet.ViewModels
{
    public class VmLayout
    {
        public List<Articles> Articles { get; set; }
        public List<Sosial> Sosial { get; set; }
        public List<Subscribe> Subscribe { get; set; }
        public List<Twitter> Twitter { get; set; }
        public Setting Setting { get; set; }
    }
}
