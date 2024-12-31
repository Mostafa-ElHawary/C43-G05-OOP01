using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G05_OOP01
{
    internal struct Employee
    {

        //private int Id;
        //private string Name;
        //private int Salary;

        //public override string ToString()
        //{
        //   return $"{Id} , {Name} , {Salary}";
        //}

        // with using Encapsulation we have 2 way 

        // 1. Apply Encapsulation Using Setter Getter Methods

        ////setter
        //public void SetId(int id) { 

        //    this.Id = id ;
        //}
        //public void SetName(string name) { 

        //    this.Name = name ;
        //}

        //public void SetSalary(int salary)
        //{
        //    this.Salary = 0 ;
        //}

        //// getter 

        //public int GetId()
        //{
        //  return Id;
        //}
        //public string GetName() { 
        // return Name;
        //}

        //public Employee(int id , string name , int salary) {


        //    SetId(id);  
        //    SetName(name);
        //    SetSalary(salary);
        //}


        // 2. Applay Encapsulation Using Properties

        // Properties : 
        // 1. Full Property
        // 2. Automatic Property
        // 3. Special Property

        //Ex 
        // 1. Full Property

        //public int id
        //{
        //    set { Id = value; }
        //    get { return Id; }

        //}

        //// 2. Automatic Property
        //public int Age
        //{
        //    set; get; 

        //}

        // 3. Special Property : Indexer
        // 3.1 Named this
        // 3.2 Take Parameter 



    }
}
