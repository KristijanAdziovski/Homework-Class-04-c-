using System;
using System.Collections.Generic;
using System.Text;

namespace Homework1
{
   public  class Fish : Pet
    {

        public string Color { get; set; }
        public int Size { get; set; }

        public Fish(string name, int age , string type , string color, int size) : base(name, age)
        {
            Type = type;
            Color = color;
            Size = size;
        }

        public override string PrintInfo()
        {
            return $"{Name} of {Type} is {Size} cm long , and his color is {Color}";
        }
    }
}
