using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ClassLibrary1.DB
{
    public class Patient
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column(TypeName = "NVARCHAR")]
        [StringLength(50)]
        public string Name { get; set; }

        [Column(TypeName = "NVARCHAR")]
        [StringLength(50)]
        public string Surname { get; set; }

        public DateTime dateOfBirth { get; set; }


        [Column(TypeName = "NVARCHAR")]
        [StringLength(100)]
        public string Diagnosis { get; set; }
    }
}
