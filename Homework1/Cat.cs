using System;
using System.Collections.Generic;
using System.Text;

namespace Homework1
{
   public  class Cat : Pet
    {
     

        public bool Lazy { get; set; }
        public int LivesLeft { get; set; }

        public Cat(string name, int age, string type ,bool lazy, int livesLeft) : base(name,age)
        {
            Lazy = lazy;
            LivesLeft = livesLeft;
            Type = type;
        }

        public override string PrintInfo()
        {
           if (Lazy)
            {
                return $"{Name} is a lazy cat with {LivesLeft} lives left";
            }
            else
            {
                return $"{Name} is not a lazy cat with {LivesLeft} lives left";
            }
        }
    }
}
