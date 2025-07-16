using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudieApplication.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentId { get; set; }

        [MaxLength(50)]
        [MinLength(5)]
        public string StudentName { get; set; }

        public bool IsActive { get; set; }
    }
}
