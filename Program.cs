using System;
using System.Collections.Generic;

namespace CollPrac
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            string[] words = {"Tim", "Martin", "Nikki", "Sara"};
            bool[] falsie = {true, false, true, false, true, false, true, false, true, false};


            List<string> iceCream = new List<string>();
            iceCream.Add("vanilla");
            iceCream.Add("chocolate");
            iceCream.Add("strawberry");
            iceCream.Add("mint-chocolate chip");
            iceCream.Add("coffee");
            Console.WriteLine(iceCream.Count);
            Console.WriteLine(iceCream[2]);
            iceCream.RemoveAt(2);
            Console.WriteLine(iceCream.Count);

            Dictionary<string, string> names = new Dictionary<string, string>();
            
            foreach(string word in words){
                names.Add(word, null);
            }

            Random rand = new Random();

            var keys = new List<string>(names.Keys);

            foreach(var key in keys){
                names[key] = iceCream[rand.Next(0,4)];
            }

            foreach(var pair in names){
                Console.WriteLine("Name: "+ pair.Key + "Favorite Ice Cream: "+ pair.Value);
            }
        }
    }
}
