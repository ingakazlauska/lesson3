using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Inga");
            Person person2 = person;


            // person.Name = "Inga123";
            person.Age = 31;
            person.IsMale = false;
            person.Money = 1258.569;
            person.Initial = 'A';

            person2.Age = 26;   

            string greeting = person.GetGreeting();

            Console.WriteLine(greeting);

        }
    }
}
