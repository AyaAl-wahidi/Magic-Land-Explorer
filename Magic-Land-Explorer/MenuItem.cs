using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Land_Explorer
{
    public delegate void MenuAction();
    public class MenuItem
    {
        public string description { get; set; }
        public MenuAction action { get; set; }

        public MenuItem(string des, MenuAction act)
        {
            description = des;
            action = act;
        }
    }

    public class Menu
    {
        private readonly List<MenuItem> _items;

        public Menu(List<MenuItem> items) {
            _items = items;
        }

        public void Display()
        {          
            while (true)
            {                
                foreach (MenuItem item in _items)
                {
                    Console.WriteLine("\n---------------------- Please Select The Action ----------------------");
                    foreach (MenuItem x in _items)
                    {
                        Console.WriteLine(x.description);
                    }
                    //Console.WriteLine("Please Select The Action : \n1. Filter Durations That Are Less Than 100 Mins \n2. Top Three Dutartion \n3. Alphabetically List \n4. Longest Destination \n5. Fantasyland Locations");

                    if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 1 && choice <= _items.Count)
                    {
                        _items[choice - 1].action();
                        if (_items[choice - 1].description == "Exit")
                        {
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid selection. Please try again.");
                        Pause();
                    }
                }
            }
        }

        public static void Pause()
        {
            Console.ReadKey();
        }
    }
}