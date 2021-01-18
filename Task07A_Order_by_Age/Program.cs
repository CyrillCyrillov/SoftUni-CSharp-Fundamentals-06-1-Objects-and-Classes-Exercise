﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Task07_Order_by_Age
{
    class Person
    {
        public Person(string name, string iD, int age)
        {
            Name = name;
            ID = iD;
            Age = age;
        }

        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} with ID: {ID} is {Age} years old.";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Person> listOfMembers = new List<Person>();

            while (true)
            {
                string[] rawComand = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                if(rawComand[0].ToUpper() == "END")
                {
                    break;
                }

                Person nextName = new Person(rawComand[0], rawComand[1], int.Parse(rawComand[2]));
                listOfMembers.Add(nextName);

            }

            listOfMembers = listOfMembers.OrderBy(x => x.Age).ToList(); ;
            //listOfMembers.Reverse();
            
            Console.WriteLine(string.Join(Environment.NewLine, listOfMembers));
        }
    }
}
