using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace MvcefApp.Models
{
    public class Doctor
    {

        [Key]
        [Column("doctorno")]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        [MinLength(3, ErrorMessage =("name must be between 3 and 20 characters"))]
        


        

        public string Name { get; set; } = string.Empty;


        [Required]
        
        public string Speciality { get; set; } = string.Empty;
        [Required]

        public DateTime DateOfBirth { get; set; }
        [Required]
        [Column(TypeName = "numeric(18,2)")]

        public decimal visitingFee { get; set; }
        [Required]

        public long PhoneNumber { get; set; }

    }
}
