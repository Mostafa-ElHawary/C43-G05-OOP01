using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G05_OOP01
{
    internal struct PhoneBook
    {
        string[] names;
        long[] numbers;
        public PhoneBook(int size)
        {
            this.names = new string[size];
            this.numbers = new long[size];
            
        }

        public void AddPerson(string name , long number , int index) {

            names[index] = name;
            numbers[index] = number;

        }

        public long GetNumber(string name) {

            for (int i = 0; i < names.Length; i++) {

                if (names[i] == name) { 
                 
                    return numbers[i];
                }
            }
            return -1 ;
        
        }

        public void UpdateNumber(string name , long newNum)
        {
            for (int i = 0; i < names.Length; i++)
            {

                if (names[i] == name)
                {

                   numbers[i] = newNum;
                    return;
                }
            }
        }

         // Ex On Indexer

        public long this[string name]
        {
            set {

                for (int i = 0; i < names.Length; i++)
                {

                    if (names[i] == name)
                    {

                        numbers[i] = value;
                        return;
                    }
                }

            }
            get {

                for (int i = 0; i < names.Length; i++)
                {

                    if (names[i] == name)
                    {

                        return numbers[i];
                    }
                }
                return -1;
            } 
        }
    }
}
