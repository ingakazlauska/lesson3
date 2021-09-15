using System;


namespace ConsoleApp3
{

    public class Person

    {

        public Person(string name)
        {
            Name = name;
        }
        public string Name { get; }

        private int _age;
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = Math.Abs(value);
            }
        }

        public int Age2 { get; set; }

        public double Money { get; set; }

        public bool IsMale { get; set; }

        public char Initial { get; set; }

        public String GetGreeting()
        {
            string greeting = "Hello, my name is " + Name + " and I am " + Age + " years old!";

            return greeting;


        }
    }
}
