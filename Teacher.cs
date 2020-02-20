using System;
using System.Collections.Generic;
using System.Text;

namespace Student
{
    public class Teacher:Person
    {
        public string Subject { get; set; }
        public string School { get; set; }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($" {Subject}, {School} ");
        }

    }
   
}
