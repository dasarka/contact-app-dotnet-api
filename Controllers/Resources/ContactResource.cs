using System;
using System.ComponentModel.DataAnnotations;

namespace ContactApp.Controllers.Resources
{
    public class ContactResource
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        public byte Gender { get; set; }
        public DateTime Birth { get; set; }
        [Required]
        public string Techno { get; set; }
        public string Message { get; set; }
    }
}