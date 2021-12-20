using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Barnet.Models
{
    public class Services
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Page { get; set; }
        [NotMapped]
        public IFormFile PageFile { get; set; }
        [MaxLength(50)]
        public string Logo { get; set; }
        [NotMapped]
        public IFormFile LogoFile { get; set; }
        [MaxLength(50)]
        public string Title { get; set; }
        [MaxLength(50)]
        public string Content { get; set; }
        public DateTime CreateDate { get; set; }

        [ForeignKey("ServicesCategory")]
        public int ServicesCategoryİd { get; set; }
        public ServicesCategory ServicesCategory { get; set; }
    }
}
