using System;
using System.Diagnostics;

namespace MembersC
{
    class Members
    {
        // member - private field
        private string memberName;
        private string jobTitle;
        private int salary;

        // member - public field
        public int age;

        // member - property - exposes jobTitle safely - properties start with capital letter
        public string JobTitle
        {
            get
            {
                return jobTitle;
            }
            set
            {
                jobTitle = value;
            }
        }

        // public member method - can be called from other classes
        public void Introducing(bool isFriend)
        {
            if (isFriend)
            {
                sharingPrivateInfo();
            }
            else
            {
                Console.WriteLine("Hi, my name is {0} and my job title is {1} and I'm {2} years old.", memberName, jobTitle, age);
            }
        }

        private void sharingPrivateInfo()
        {
            Console.WriteLine("My salary is {0}", salary);
        }

        // members constructor
        public Members()
        {
            age = 30;
            memberName = "Lucy";
            salary = 60000;
            jobTitle = "Developer";
            Console.WriteLine("Object created");

        }

        // members finalizer - destructor
        ~Members()
        {
            // cleanup statements
            Console.WriteLine("Deconstructor of members object");
            Debug.Write("Destruction of members object");
        }

    }
}
