
using System.ComponentModel.DataAnnotations;

public class TeacherDb
    {
        [Key]
        public int Id { get; set; }
            
        [Required]
        public string TeacherName { get; set; }

        [Required]
        public int TeacherContact{ get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime UpdatedAt { get; set; } = DateTime.Now;
     
}

