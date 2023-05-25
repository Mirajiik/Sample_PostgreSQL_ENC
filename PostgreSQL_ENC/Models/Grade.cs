using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PostgreSQL_ENC.Models
{
    class Grade
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("date")]
        public DateTime Date { get; set; }
        [Required]
        [Column("name_subject")]
        public string NameSubject { get; set; }
        [Required]
        [Column("grade_value")]
        public byte GradeValue { get; set; }
    }
}
