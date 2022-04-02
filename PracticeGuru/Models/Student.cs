using System.ComponentModel.DataAnnotations;

namespace PracticeGuru.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int StudentName { get; set; }

        [Required]
        public int StudentContact { get; set; }

        public DateTime Created_at { get; set; } = DateTime.Now;
        public DateTime Updated_at { get; set; } = DateTime.Now;
    }
}
