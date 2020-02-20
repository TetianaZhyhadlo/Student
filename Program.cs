using System;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher first = new Teacher();
            first.Name = "Halyna";
            first.LastName = "Ivanova";
            first.PhoneNumber = 11223344;
            first.School = "KyivLanguageSchool";
            first.Subject = "Biology";

            Students s1 = new Students();
            s1.Name = "Tanya";
            s1.LastName = "Petrova";
            s1.PhoneNumber = 1234567889;
            s1.Level = 1;
            s1.Course = "English";

            first.ShowInfo();
            s1.ShowInfo();


        }
    }
}
