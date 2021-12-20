using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Barnet.Models
{
    public class Articles
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        [MaxLength(50)]
        public string Title { get; set; }
    }
}
