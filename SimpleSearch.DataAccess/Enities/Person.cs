using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MySearchApp.Models.Entities
{
    [Table("Persons")]
    public class Person
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(255)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(255)]
        public string LastName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public int Age { get; set; }

        public string Intrest { get; set; }

        public byte[] Photo { get; set; }
    }
}