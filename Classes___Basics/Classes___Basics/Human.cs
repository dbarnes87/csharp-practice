using System;
namespace Classes___Basics
{
    // this class is a blueprint of a datatype
    public class Human
    {
        // member variable
        private string firstName;
        private string lastName;
        private string eyeColor;
        private int age;

        // default constructor
        public Human()
        {
            Console.WriteLine("Constructor called.  Object created.");
        }

        public Human(string firstName)
        {
            this.firstName = firstName;
        }

        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        // parameterized constructor
        public Human(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public Human(string firstName, string lastName, string eyeColor)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor; 
        }

        // parameterized constructor
        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }

        // member method
        public void IntroduceMyself()
        {
            if (age != 0 && lastName != null && eyeColor != null && firstName != null)
                Console.WriteLine("Hi, I'm {0} {1} and am {2} years old.  My eyes are {3}.", firstName, lastName, age, eyeColor);
            else if (age != 0 && lastName != null && firstName != null)
                Console.WriteLine("Hi, I'm {0} {1} and am {2} years old.", firstName, lastName, age);
            else if (lastName != null && firstName != null)
                Console.WriteLine("Hi, I'm {0} {1}.", firstName, lastName);
            else
                Console.WriteLine("Hi, I'm {0}.", firstName);
        }
    }
}
