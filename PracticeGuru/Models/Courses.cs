using System.ComponentModel.DataAnnotations;

namespace PracticeGuru.Models
{
    public class Courses
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int CoueseName { get; set; }

        [Required]
        public int CourseDescription { get; set; }

        public DateTime Created_at { get; set; } = DateTime.Now;
        public DateTime Updated_at { get; set; } = DateTime.Now;

    }
}
