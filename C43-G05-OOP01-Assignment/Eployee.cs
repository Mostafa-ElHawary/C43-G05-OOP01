using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G05_OOP01_Assignment
{
    public enum SecurityPrivilege
    {
        Guest,
        Developer,
        Secretary,
        DBA,
        SecurityOfficer 

    }

    internal class Employee
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public SecurityPrivilege SecurityLevel { get; set; }
        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }

        private char _gender;
        public char Gender
        {
            get { return _gender; }
            set
            {
                if (value == 'M' || value == 'F')
                {
                    _gender = value;
                }
                else
                {
                    throw new ArgumentException("Gender must be 'M' or 'F'.");
                }
            }
        }


        public Employee(int id, string name, SecurityPrivilege securityLevel, decimal salary, DateTime hireDate, char gender)
        {
            ID = id;
            Name = name;
            SecurityLevel = securityLevel;
            Salary = salary;
            HireDate = hireDate;
            Gender = gender;
        }


        public override string ToString()
        {
            return $"ID: {ID}\n" +
                   $"Name: {Name}\n" +
                   $"Security Level: {SecurityLevel}\n" +
                   $"Salary: {string.Format("{0:C}", Salary)}\n" + 
                   $"Hire Date: {HireDate.ToShortDateString()}\n" +
                   $"Gender: {Gender}";
        }


        public class HiringDate : IComparable<HiringDate> 
        {
            public int Day { get; set; }
            public int Month { get; set; }
            public int Year { get; set; }

            public HiringDate(int day, int month, int year)
            {
                if (day < 1 || day > 31 || month < 1 || month > 12 || year < 1900 || year > DateTime.Now.Year)
                {
                    throw new ArgumentOutOfRangeException("Invalid date values.");
                }

                Day = day;
                Month = month;
                Year = year;
            }

            public int CompareTo(HiringDate other)
            {
                if (other == null) return 1;

                int yearComparison = Year.CompareTo(other.Year);
                if (yearComparison != 0) return yearComparison;

                int monthComparison = Month.CompareTo(other.Month);
                if (monthComparison != 0) return monthComparison;

                return Day.CompareTo(other.Day);
            }

            public override string ToString()
            {
                return $"{Year}/{Month:D2}/{Day:D2}"; 
            }
        }


    }
}
