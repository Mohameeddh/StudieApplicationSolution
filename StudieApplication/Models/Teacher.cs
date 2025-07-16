using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudieApplication.Models
{
    public class Teacher
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TeacherId { get; set; }

        [MaxLength(60)]
        [MinLength(10)]
        public string TeacherName { get; set; }

        [Range(22,70)]
        public int Age { get; set; }
    }
}
