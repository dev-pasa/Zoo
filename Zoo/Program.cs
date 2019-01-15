using System;
using Zoo.Classes;
using Zoo.interfaces;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Cats[] cats = Catlist();
            CatItems(cats);
        }

        public static Cats[] Catlist()
        {
            Cats[] catList = new Cats[3];
            catList[0] = new Lion();
            catList[1] = new Tiger();
            catList[2] = new Leopard();
            return catList;
        }

        public static void CatItems(Cats[] catList)
        {
            foreach (Cats cat in catList)
            {
                Console.WriteLine($"Name of the cat: {cat.Name}");
                Console.WriteLine($"Age of the cat: {cat.Age}");
                Console.WriteLine($"Claw length: {cat.ClawLength}");
                Console.WriteLine($"Eats: {cat.Food()}");
                Console.WriteLine();
            }
        }
    }
}
