using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContactApp.Models
{
    [Table("Contacts")]
    public class Contact
    {
        public long Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [Required]
        [StringLength(255)]
        public string Email { get; set; }
        public byte Gender { get; set; }
        public DateTime Birth { get; set; }
        [Required]
        [StringLength(255)]
        public string Techno { get; set; }
        public string Message { get; set; }
    }
}