using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PostgreSQL_ENC.Models
{
    class Teacher
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
        [ForeignKey("teacher_id")]
        public ICollection<Grade> TeacherId { get; set; }
    }
}
