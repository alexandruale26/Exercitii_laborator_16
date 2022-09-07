using Exercitii_laborator_16.Data;
using Exercitii_laborator_16.Models;
using Exercitii_laborator_16;


SeedTable();

using StudentsContextDB context = new StudentsContextDB();

context.Students.OrderBy(s => s.LastName + s.FirstName).ToList().ForEach(s => Console.WriteLine(s));

var stud1 = context.Students.Where(s => s.Specialization == Specialization.CivilEngineering && s.Age > 20).OrderBy(s => s.Age).FirstOrDefault();
Console.WriteLine($"\nCel mai tanar de la constructii de peste 20 de ani este {stud1}"); 

static void SeedTable()
{
    using StudentsContextDB context = new StudentsContextDB();

    if (context.Students.Any()) return;

    context.Students.Add(new Student
    {
        FirstName = "Marian",
        LastName = "Potop",
        Age = 38,
        Specialization = Specialization.Letters
    });

    context.Students.Add(new Student
    {
        FirstName = "Gabriel",
        LastName = "Mihailescu",
        Age = 34,
        Specialization = Specialization.Letters
    });

    context.Add(new Student
    {
        FirstName = "Mihai",
        LastName = "Campeanu",
        Age = 24,
        Specialization = Specialization.ComputerScience
    });

    context.Add(new Student
    {
        FirstName = "David",
        LastName = "Marica",
        Age = 23,
        Specialization = Specialization.CivilEngineering
    });

    context.Add(new Student
    {
        FirstName = "Andrei",
        LastName = "Balint",
        Age = 22,
        Specialization = Specialization.CivilEngineering
    });

    context.Add(new Student
    {
        FirstName = "Mihaela",
        LastName = "Campeanu",
        Age = 19,
        Specialization = Specialization.CivilEngineering
    });

    context.Students.Add(new Student
    {
        FirstName = "Maria",
        LastName = "Potop",
        Age = 18,
        Specialization = Specialization.ComputerScience
    });

    context.Add(new Student
    {
        FirstName = "Valeriu",
        LastName = "Ababei",
        Age = 28,
        Specialization = Specialization.Letters
    });
    

    context.SaveChanges();
}