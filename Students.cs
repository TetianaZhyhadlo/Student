using System;
using System.Collections.Generic;
using System.Text;

namespace Student
{
    public class Students: Person
    {  
        public string Course { get; set; }
        public int Level { get; set; }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($" {Course}, {Level} ");
        }
    }
}
