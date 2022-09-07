using System.ComponentModel.DataAnnotations;

namespace Exercitii_laborator_16.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public int Age { get; set; }
        public Specialization Specialization { get; set; }


        public override string ToString() => $"{LastName} {FirstName} {Age} {Specialization}";
    }
}
