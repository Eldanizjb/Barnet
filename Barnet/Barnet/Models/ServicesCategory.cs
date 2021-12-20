﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Barnet.Models
{
    public class ServicesCategory
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Text { get; set; }

        public List<Services> Services { get; set; }
    }
}
