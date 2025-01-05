using System;

namespace ManagementSystem
{
    //Kişi sınıfı oluşturalım.
    public class Person
    {
        public string name;
        public string surname;
        public DateTime dateOfBirth;

        //İsim özelliğini tanımlayalım.
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        //Soyisim özelliğini tanımlayalım.
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }

        //Doğum tarihi özelliğini tanımlayalım.
        public DateTime DateOfBirth
        {
            get
            {
                return dateOfBirth;
            }
            set
            {
                dateOfBirth = value;
            }
        }
    }

    
    class Program
    {
        static void Main()
        {
            //2 tane örnek öğrenci nesnesi oluşturalım.
            Person student1 = new Person
            {
                Name = "Masal",
                Surname = "Masalingo",
                DateOfBirth = new DateTime(2005, 8, 15)
            };

            Person student2 = new Person
            {
                Name = "Duman",
                Surname = "Leopar",
                DateOfBirth = new DateTime(2006, 11, 22)
            };

            //2 tane örnek öğretmen nesnesi oluşturalım.
            Person teacher1 = new Person
            {
                Name = "Seto",
                Surname = "İspir",
                DateOfBirth = new DateTime(1980, 4, 12)
            };

            Person teacher2 = new Person
            {
                Name = "Sagopa",
                Surname = "Kajmer",
                DateOfBirth = new DateTime(1985, 6, 30)
            };

            //Öğrenci bilgilerini yazdıralım.

            Console.WriteLine("Students:\n" +
                              $"Name: {student1.Name} {student1.Surname}, Date of Birth: {student1.DateOfBirth.ToShortDateString()} | " +
                              $"Name: {student2.Name} {student2.Surname}, Date of Birth: {student2.DateOfBirth.ToShortDateString()}");

            //Öğretmen bilgilerini yazdıralım.

            Console.WriteLine("\nTeachers:\n" +
                              $"Name: {teacher1.Name} {teacher1.Surname}, Date of Birth: {teacher1.DateOfBirth.ToShortDateString()} | " +
                              $"Name: {teacher2.Name} {teacher2.Surname}, Date of Birth: {teacher2.DateOfBirth.ToShortDateString()}");
        }
    }
}
