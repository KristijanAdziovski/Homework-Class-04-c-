using System;
using System.Collections.Generic;
using System.Text;

namespace Homework1
{
    public class Dog : Pet
    {
       
        public bool GoodBoi { get; set; }
        public string FavouriteFood { get; set; }

        public Dog(string name, int age, string type,bool goodBoi, string favouriteFood ) : base(name, age)
        {
            Type = type;
            GoodBoi = goodBoi;
            FavouriteFood = favouriteFood;
        }

        public override string PrintInfo()
        {
            if (GoodBoi)
            {
                return $"{Name} is a good boy, it's favourite food is {FavouriteFood} ";
            }
            else
            {
                return $"{Name} is a bad boy, it's favourite food is {FavouriteFood} ";
            }
        }

    }
}
