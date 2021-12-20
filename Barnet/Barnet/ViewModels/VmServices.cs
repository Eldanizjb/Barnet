using Barnet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Barnet.ViewModels
{
    public class VmServices : VmLayout
    {
      
        public Banner Banner { get; set; }
        public List<Services> Service { get; set; }
        public List<ServicesCategory> ServicesCategories { get; set; }
        public List<Solution> Solution { get; set; }
        public List<SolutionCategory> SolutionCategories { get; set; }
        public List<Feedback> Feedback { get; set; }

    }
}
