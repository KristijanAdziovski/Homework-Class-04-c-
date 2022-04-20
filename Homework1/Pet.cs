using System;
using System.Collections.Generic;
using System.Text;

namespace Homework1
{
    public abstract class Pet
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Age { get; set; }


        protected Pet(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public abstract string PrintInfo();
    }
}
