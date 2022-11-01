using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    internal class Program
    {
        static List<string> items = new List<string>();

        static void Main(string[] args)
        {
            items.Add("Sword");
            items.Add("Shield");
            items.Add("Potion");

            // how many it can fit before resizing:
            Console.WriteLine("Capacity: " + items.Capacity);

            // how many it has currently:
            Console.WriteLine("Count: " + items.Count);

            // if your list name is a plural, then the singular works to denote one entry in the list:
            foreach (string item in items)
            {
                Console.WriteLine(item);
            }

            // search if the list contains a certain string:
            Console.WriteLine("Contains \"Potion\": " + items.Contains("Potion"));

            // insert a string at a certain spot
            Console.WriteLine("Insert at spot 2 in the list, \"Scabbard\")");
            items.Insert(1, "Scabbard");

            Console.WriteLine("");

            foreach (string item in items)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey(true);

            // Shows accessing the list using the Item property.
            Console.WriteLine("Items[1]: " + items[1]);

            Console.ReadKey(true);

            // removing entries:
            Console.WriteLine("Remove \"Potion\"");
            items.Remove("Potion");

            items.Add("Bow");
            items.Add("Arrows");
            items.Add("Coins");
            items.Add("Rocks");
            items.Add("Severed Head");

            //trims off empty list cells (doesn't work if list is over 90% capacity)
            items.TrimExcess();
            Console.WriteLine("TrimExcess:");
            Console.WriteLine("Capacity: " + items.Capacity);
            Console.WriteLine("Count: " + items.Count);

            //empties all list cells
            // items.Clear();

            Test();


            items.Remove("Bow");
            items.Remove("Arrows");
            items.Remove("Rocks");

            Test();
            items.TrimExcess();

            Test();

            
        }

        static void Test()
        {
            Console.WriteLine("");
            Console.WriteLine("Capacity: " + items.Capacity);
            Console.WriteLine("Count: " + items.Count);
            Console.WriteLine("");
            Console.WriteLine("Contents:");
            foreach (string item in items)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey(true);
        }

    }
}
