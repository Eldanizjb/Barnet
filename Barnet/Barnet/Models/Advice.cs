using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Barnet.Models
{
    public class Advice
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(200)]
        public string Content { get; set; }
    }
}
