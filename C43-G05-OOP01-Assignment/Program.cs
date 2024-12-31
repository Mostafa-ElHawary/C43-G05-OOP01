using System.ComponentModel;
using System.Drawing;
using static C43_G05_OOP01_Assignment.Employee;

namespace C43_G05_OOP01_Assignment
{
    internal class Program
    {
        static int Main(string[] args)
        {

            #region Part 01

            #region Q1

            // Create a struct called "Point" to represent a 2D point
            // with properties "X" and "Y". Write a C# program
            // that takes two points as input from the user and calculates
            // the distance between them.


            //Point point1 = Point.GetPointFromInput("Point 1");

            //Point point2 = Point.GetPointFromInput("Point 2");


            //double distance = Point.Distance(point1, point2);
            //Console.WriteLine($"Distance between the two points: {distance}");

            #endregion


            #region Q2

            //Person[] people = new Person[3];

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Enter details for person {i + 1}:");
            //    Console.Write("Name: ");
            //    string name = Console.ReadLine();

            //    Console.Write("Age: ");
            //    int age = int.Parse(Console.ReadLine()); 


            //    people[i] = new Person(name, age);


            //}

            //Person oldestPerson = people[0];
            //for (int i = 1; i < 3; i++)
            //{
            //    if (people[i].Age > oldestPerson.Age)
            //    {
            //        oldestPerson = people[i];
            //    }
            //}

            //Console.WriteLine("\nOldest Person:");
            //Console.WriteLine($"Name: {oldestPerson.Name}");
            //Console.WriteLine($"Age: {oldestPerson.Age}");


            #endregion


            #endregion


            #region Part 02


            #region Q1
            try
            {
                Employee[] EmpArr = new Employee[3];

                EmpArr[0] = new Employee(1, "Marwan Attea", SecurityPrivilege.DBA, 70000m, new DateTime(2022, 1, 15), 'M');
                EmpArr[1] = new Employee(2, "Elsyed Zizo", SecurityPrivilege.Guest, 30000m, new DateTime(2023, 5, 10), 'F');
                EmpArr[2] = new Employee(3, "Emam Ashour", SecurityPrivilege.SecurityOfficer, 90000m, new DateTime(2021, 7, 1), 'M');




                List<Employee> employeeList = new List<Employee>(EmpArr);
                employeeList.Sort((e1, e2) => e1.HireDate.CompareTo(e2.HireDate));


                Console.WriteLine("Sorted Employees:");
                foreach (Employee emp in employeeList)
                {
                    Console.WriteLine(emp);
                    Console.WriteLine();
                }


            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return 1; 
            }
            catch (ArgumentException ex) 
            {
                Console.WriteLine($"Error: {ex.Message}");
                return 1;
            }



            return 0; 
        }
        #endregion


        #endregion
    }
    }

