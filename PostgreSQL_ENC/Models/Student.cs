using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PostgreSQL_ENC.Models
{
    class Student
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("first_name")]
        public string FirstName { get; set; }
        [Required]
        [Column("last_name")]
        public string LastName { get; set; }
        [Required]
        [Column("course")]
        public byte Course { get; set; }
        [ForeignKey("student_id")]
        public ICollection<Grade> StudentId { get; set; }
    }
}
