using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using WebApplication6.Interfaces;

namespace WebApplication6.Models
{
    public class Emplooyes
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Profession { get; set; }
    }
}
