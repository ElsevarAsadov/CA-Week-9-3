using System.ComponentModel.DataAnnotations;
using WebApplication6.Interfaces;

namespace WebApplication6.Models
{
    public class Services
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
