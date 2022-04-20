using System;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat("Marko", 11, "Persian cat", false, 5);
            Cat cat2 = new Cat("Sharko", 9, "Ragdoll cat", true, 8);
            Cat cat3 = new Cat("Mia", 14, "Siberian cat", false, 3);
            Cat cat4 = new Cat("Leo", 18, "Savannah cat", true, 11);

            Dog dog1 = new Dog("Max", 3, "Maltezer", true, "meat");
            Dog dog2 = new Dog("Alex", 11, "Beagle", false, "dog food");
            Dog dog3 = new Dog("Buba", 9, "Bull dog", true, "steak");
            Dog dog4 = new Dog("Mayle", 3, "Maltezer", true, "sausage");

            Fish fish1 = new Fish("Gold",2,"Oslic","White",22);
            Fish fish2 = new Fish("Nemo", 4, "Popadika", "Yellow", 15);
            Fish fish3 = new Fish("Sharky", 8, "Shark", "Blue", 452);
            Fish fish4 = new Fish("Delfin", 11, "Delfin", "White-Blue", 256);

            PetStore<Cat> catStore = new PetStore<Cat>();
            catStore.Add(cat1);
            catStore.Add(cat2);
            catStore.Add(cat3);
            catStore.Add(cat4);

            PetStore<Dog> dogStore = new PetStore<Dog>();
            dogStore.Add(dog1);
            dogStore.Add(dog2);
            dogStore.Add(dog3);
            dogStore.Add(dog4);

            PetStore<Fish> fishStore = new PetStore<Fish>();
            fishStore.Add(fish1);
            fishStore.Add(fish2);
            fishStore.Add(fish3);
            fishStore.Add(fish4);

            Console.WriteLine("Cat for adoptions:");
            catStore.PrintPets();

            Console.WriteLine("Dog for adoptions:");
            dogStore.PrintPets();

            Console.WriteLine("Fish for adoptions:");
            fishStore.PrintPets();

            Console.WriteLine("Buy a dog:");
            dogStore.BuyPet("Alex");
            dogStore.BuyPet("Max");

            Console.WriteLine("Buy a cat:");
            catStore.BuyPet("Marko");
            catStore.BuyPet("Mia");

            Console.WriteLine("Buy a fish:");
            fishStore.BuyPet("Gold");
            fishStore.BuyPet("Nemo");

            Console.WriteLine("Dog left for adoption :");
            dogStore.PrintPets();

            Console.WriteLine("Cat left for adoption :");
            catStore.PrintPets();

            Console.WriteLine("Fish left for adoption :");
            fishStore.PrintPets();
        }
    }
}
