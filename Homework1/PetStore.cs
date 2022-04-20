using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework1
{
   public  class PetStore<T> where T : Pet
    {
        public List<T> ListOfPets = new List<T>();
         
        public PetStore()
        {
            ListOfPets = new List<T>();
        }
        public void PrintPets()
        {
            for(int i = 0; i < ListOfPets.Count; i++)
            {
                if(ListOfPets.Count == 0)
                {
                    Console.WriteLine("No Pets for Adoption in the Store");
                }
                else
                {
                    Console.WriteLine($"{i+1} {ListOfPets[i].PrintInfo()}");
                }
            }
        }

        public void BuyPet (string name)
        {
            try
            {
                var pet = ListOfPets.Single(x => string.Equals(x.Name, name, StringComparison.OrdinalIgnoreCase));
                ListOfPets.Remove(pet);
                Console.WriteLine($"{name} is ready for adoption");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"PEt with the name {name} does not exist");
            }
        }

        public void Add(T pet)
        {
            ListOfPets.Add(pet);
        }
    }
}
