using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Barnet.Models
{
    public class Setting
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(30)]
        public string BannerPhone { get; set; }
        [MaxLength(50)]
        public string BannerEmail { get; set; }
        [MaxLength(50)]
        public string Logo { get; set; }
        [NotMapped]
        public IFormFile LogoFile { get; set; }
        [MaxLength(50)]
        public string About { get; set; }
        [MaxLength(100)]
        public string Address { get; set; }
        [MaxLength(30)]
        public string Phone { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
    }
}
