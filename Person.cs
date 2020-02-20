using System;
using System.Collections.Generic;
using System.Text;

namespace Student
{
    public class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
        public virtual void ShowInfo()
        {
            Console.WriteLine("Info: {0} {1}; {2}",Name,LastName,PhoneNumber);
        }
    }
}
