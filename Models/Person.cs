using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers___Encaptulation.Models
{
    public class Person
    {
        public Person()
        {
            Console.WriteLine("Person Created");
        }
        public Person(string name, string surname, int age, int birthday)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.birthday = birthday;
        }

        #region Encaptulation - u birinci fieldlərə get və set methodları
        private string _name;
        private int _age;
        public string name
        {
            get
            {
                return _name;
            }


            set
            {
                if (value.Length >= 2)
                {
                    _name = value;
                    return;
                }
                Console.WriteLine("{...the length of the name is small, 2 den ...}");
            }
        }
        public string surname { get; set; }
        public int age
        {

            get
            {
                return _age;
            }
            set
            {
                if (value >= 16)
                {
                    _age = value;
                    return;
                }
                Console.WriteLine("{...your age is small...}");
            }
        }
        public int birthday { get; set; }

        public void Print()
        {
            Console.WriteLine("{");
            Console.WriteLine("Name :" + $"{name}");
            Console.WriteLine("Surname :" + $"{surname}");
            Console.WriteLine("Age :" + $"{age}");
            Console.WriteLine("Birthday :" + $"{birthday}");
            Console.WriteLine("}");

        }

        #endregion


        //#region propertinin get və set methodıarənə override edərək

        //public Person(string name, string surname, int age, int birthday)
        //{
        //    _name = name;
        //    this.surname = surname;
        //    _age = age;
        //    this.birthday = birthday;
        //}

        //private string _name;
        //public string surname;
        //private int _age;
        //public int birthday;

        //public void SetName(string value)
        //{
        //    if (value.Length >= 2)
        //    {
        //        _name = value;

        //    }
        //    else
        //    {
        //        Console.WriteLine("{...the length of the name is small, 2 den ...}");

        //    }
        //}
        //public string GetName()
        //{

        //    return _name;
        //}
        //public void SetAge(int value)
        //{
        //    if (value >= 16)
        //    {
        //        _age = value;

        //    }
        //    else
        //    {
        //        Console.WriteLine("{...your age is small...}");

        //    }
        //}
        //public int GetAge()
        //{

        //    return _age;
        //}
        //public void Print()
        //{
        //    Console.WriteLine("{");
        //    Console.WriteLine("Name :" + $"{_name}");
        //    Console.WriteLine("Surname :" + $"{surname}");
        //    Console.WriteLine("Age :" + $"{_age}");
        //    Console.WriteLine("Birthday :" + $"{birthday}");
        //    Console.WriteLine("}");

        //}
        //#endregion


    }
}
