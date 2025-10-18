using System.ComponentModel.DataAnnotations;

namespace Todo_API.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Username { get; set; }
    }
}