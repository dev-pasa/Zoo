using System;
using Zoo.Classes;
using Zoo.interfaces;

namespace Zoo
{
    public class Program
    {
        /// <summary>
        /// main method to run the method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Cats[] cats = Catlist();
            CatItems(cats);

            Reptile[] reptiles = ReptileList();
            ReptileItems(reptiles);

            Console.WriteLine(PrintLeopardName());
            Console.WriteLine(TigerOnlyEatInLand());
            Console.WriteLine(PythonSound());
        }

        /// <summary>
        /// create catlist using using cat classes
        /// </summary>
        /// <returns></returns>
        public static Cats[] Catlist()
        {
            Cats[] catList = new Cats[3];
            catList[0] = new Lion();
            catList[1] = new Tiger();
            catList[2] = new Leopard();
            return catList;
        }

        /// <summary>
        /// print the methods and properties of the cats
        /// </summary>
        /// <param name="catList"></param>
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

        /// <summary>
        /// create reptile list using reptile classes
        /// </summary>
        /// <returns></returns>
        public static Reptile[] ReptileList()
        {
            Reptile[] reptilelist = new Reptile[3];
            reptilelist[0] = new Python();
            reptilelist[1] = new Tortoise();
            reptilelist[2] = new Gharial();
            return reptilelist;
        }

        public static void ReptileItems(Reptile[] reptilelist)
        {
            foreach (Reptile reptile in reptilelist)
            {
                Console.WriteLine($"Name of the reptile: {reptile.Name}");
                Console.WriteLine($"Age of the reptile: {reptile.Age}");
                Console.WriteLine($"The lenght of the reptile: {reptile.Length}");
                Console.WriteLine($"Eats: {reptile.Food()}");
                Console.WriteLine();
            }
        }

        /// <summary>
        /// look up leapards name
        /// </summary>
        /// <returns></returns>
        public static string PrintLeopardName()
        {
            Leopard leopard = new Leopard();
            return leopard.Name;
        }

        /// <summary>
        /// check if tiger eats only in land
        /// </summary>
        /// <returns></returns>
        public static bool TigerOnlyEatInLand()
        {
            Tiger tiger = new Tiger();
            return tiger.haveToEatInLand;
        }

        /// <summary>
        /// check the sound of python
        /// </summary>
        /// <returns></returns>
        public static string PythonSound()
        {
            Python python = new Python();
            return python.Sound();
        }
    }
}
