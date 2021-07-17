using System;
using System.Linq;
using System.Collections.Generic;




namespace StudentAttendance
{
    class Program
    {
     

        static void Main(string[] args)
        {
             
            StudentAttendance();
            

            static void StudentAttendance()
            {
                Console.WriteLine("how many students would you like to Add: ");
                var studentCount = int.Parse(Console.ReadLine());

                List<string> studentName = new List<string>();
                List<int> studentId = new List<int>();


                for (int i = 0; i < studentCount; i++)
                {
                    Console.WriteLine("Please Enter the Student ID?");
                    int studentIdInput = int.Parse(Console.ReadLine());
                    studentId.Add(studentIdInput);


                    Console.WriteLine("Please Enter the Student Name?");
                    string studentNameInput = Console.ReadLine();
                    studentName.Add(studentNameInput);
                }

                Console.WriteLine("To see name of present students press 'A' or To see individual student press 'I'");
                String userChoice = Console.ReadLine();


                if (userChoice == "A")
                {
                    for (int i = 0; i < studentCount; i++)
                    {
                        Console.WriteLine("ID: {0}, Name: {1}", studentId[i], studentName[i]);
                    }
                }



                else
                {
                    Console.WriteLine("which student are you looking for?");
                    string studentFinder = Console.ReadLine();

                    if (studentName.Contains(studentFinder))
                    { Console.WriteLine($"{studentFinder} is present"); }
                    else
                    {
                        Console.WriteLine($"{studentFinder} is absent today");
                    }

                }
            }

           

        }
    }
}
