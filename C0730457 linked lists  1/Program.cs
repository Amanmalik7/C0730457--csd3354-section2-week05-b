using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0730457_linked_lists__1
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList a = new LinkedList();
        }
    }

    class Dog

    {
        public static int NumberOfDogs = 0;
        public Dog()
        {
            Dog.NumberOfDogs++;
        }
        public String DogName;
        public String DogBreed;
        public Dog nextDog;
        public Dog previousdog;

    }

    class LinkedList
    {
        public Dog current = new Dog();
        public Dog Head = new Dog();
        public Dog tail = new Dog();
        public Dog Peanut = new Dog();
        public Dog Fifi = new Dog();
        public Dog Jordan = new Dog();
        public Dog Fido = new Dog();
        public Dog Roy = new Dog();
        public Dog Coco = new Dog();

        public void run()
        {
            Head = Peanut;
            Peanut.DogName = "Peanut";
            Peanut.DogBreed = "Bichon";

            Peanut.nextDog = Fifi;
            Peanut.previousdog = null;

            Fifi.DogName = "Fifi";
            Fifi.DogBreed = "Poodle";
            

            Fifi.nextDog = Jordan;
            Fifi.previousdog = Peanut;
            Jordan.DogName = "Jordan";
            Jordan.DogBreed = "German Shepperd";

            Jordan.nextDog = Fido;
            Jordan.previousdog = Fifi;
            Fido.DogName = "Fido";
            Fido.DogBreed = "Beagle";
            Fido.nextDog = Roy;
            Fido.previousdog = Jordan;

            Roy.DogName = " roy";
            Roy.DogBreed = "lebra";
            Roy.nextDog = Coco;
            Roy.previousdog = Fido;

            Coco.DogName = "Coco";
            Coco.DogBreed = "Border collie";
            Coco.nextDog = null;
            Coco.previousdog = Peanut;
        }
        public void WalkOverTheList()
        {
            current = Head;
            while (true)
            {
                Console.WriteLine(current.DogName);
                current = current.nextDog;
            }
            
                }
    }
}
        
    

