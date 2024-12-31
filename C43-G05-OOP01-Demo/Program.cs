using System.Buffers.Text;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C43_G05_OOP01
{
    internal class Program
    {


        static void Main(string[] args)
        {
            #region Struct

            //Point P01;


            // Declare For Object (Data) From Type 'Point'
            // P01 : is a Object
            // Allocate UnInitialized 8 Bytes At STACK 

            //Console.WriteLine(P01.x);

            //Point P02 = new Point();

            //Console.WriteLine(P02.x);

            // Constructor  :Special Method
            //              1. Named Like Struct
            //              2. Has No Return

            // When Constructor created 


            //public Point()
            //{
            // x = default
            // y = default
            //}

            // you can override on default constructor 

            //public Point()
            //{
            //    x = 5
            //    y = 5
            //}

            //Point P03 = new Point(10,30);
            //Console.WriteLine(P03.x);

            //(struct)
            // Value Types: Structures are value types.This means that when you assign a struct variable to another, a copy of the data is created.Changes to one copy don't affect the other. This behavior contrasts with reference types (like classes) where assignment copies only the reference, not the underlying data.
            // Stored on the Stack: Structs are typically allocated on the stack, which is a memory region used for local variables and function calls.Stack allocation is generally faster than heap allocation(used for classes).
            // Immutability Encouraged: While not strictly enforced, immutability is a best practice with structs.This means creating structs whose values cannot be changed after initialization.You achieve this by making all fields readonly. Immutable structs are safer and easier to reason about, particularly in multi-threaded environments.
            // Suitable for Small Data Structures: Because they are copied by value, large structs can lead to performance overhead.They are best suited for representing small, self-contained data structures.


            #endregion

            #region OOP

            // The Best Paradim To Build Buisness


            // Core Concepts Or pillars : OOP is centered around the concept of "objects," which encapsulate data(fields) and behavior(methods). Key principles include:

            // Encapsulation: Bundling data and methods that operate on that data within a class, hiding internal implementation details.

            // Inheritance: Creating new classes(derived classes) based on existing ones(base classes), inheriting their properties and methods.

            // Polymorphism: The ability of objects of different classes to be treated as objects of a common type.This allows you to write code that can work with different types of objects without needing to know their specific class.

            // Abstraction: Simplifying complex systems by modeling them in terms of their essential characteristics, hiding unnecessary details.

            // -- explanation of 

            // Encapsulation:

            // Bundling Data and Methods: Encapsulation bundles data(fields) and the methods that operate on that data within a class. This protects the data from accidental or inappropriate access from outside the class.

            // Access Modifiers: C# uses access modifiers (e.g., public, private, protected) to control access to members (fields and methods) of a class.

            // Data Integrity: Encapsulation ensures data integrity by preventing direct manipulation of data from outside the class.


            // Ex01


            //Employee employee = new Employee();

            //employee.Id = 1;
            //employee.Name= "Test";
            //employee.Salary = 1000;

            //employee.ToString() ;

            // Note : without Encapsulation concept :
            // End User Can Access Data
            // No Data Validation
            // No Read Only Data

            //Employee employee = new Employee();

            //employee.SetId(1);
            //Console.WriteLine(employee.GetId());

            //employee.SetName("Ali");
            //Console.WriteLine(employee.GetName());

            //Employee employee1 = new Employee(2,"Mona" , 2000);

            //Console.WriteLine(employee1.GetId());
            //Console.WriteLine(employee1.GetName());

            // E02

            //PhoneBook phoneBook = new PhoneBook(3);

            //phoneBook.AddPerson("Ali", 342, 1);


            //Console.WriteLine(phoneBook.GetNumber("Ali"));

            //phoneBook.UpdateNumber("Ali", 111);

            //Console.WriteLine(phoneBook.GetNumber("Ali"));


            #endregion

            #region Class

            Car Car1 = new Car(1,400,"cClass-Benz");

            Car1.ToString();
            Console.WriteLine(Car1);
            #endregion
        }
    }
}
