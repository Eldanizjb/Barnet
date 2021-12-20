using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Barnet.Models
{
    public class Banner
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Title { get; set; }
        [MaxLength(50)]
        public string SupTitle { get; set; }
        [MaxLength(50)]
        public string Context { get; set; }
        [MaxLength(100)]
        public string Page { get; set; }
    }
}
