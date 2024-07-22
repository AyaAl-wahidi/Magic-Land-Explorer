using Magic_Land_Explorer.Tasks;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Magic_Land_Explorer
{
    public class Program
    {
        public static List<Category> categories;

        public static void Main(string[] args)
        {           
            ReadFile();
            StartApp();
        }

        public static void ReadFile()
        {
            string filePath = Path.Combine(Environment.CurrentDirectory, "data", "MagicLandData.json");

            // Check if the file exists
            if (!File.Exists(filePath))
            {
                Console.WriteLine($"File not found: {filePath}");
                return;
            }

            // Reading JSON data
            string json = File.ReadAllText(filePath);
            categories = JsonConvert.DeserializeObject<List<Category>>(json);
        }

        public static void StartApp()
        {
            if (categories == null)
            {
                Console.WriteLine("Failed to read categories. Exiting...");
                return;
            }

            FilterDestinations filterDestinations = new FilterDestinations();
            List<MenuItem> menuItemList = new List<MenuItem>()
            {
                new MenuItem("1. Filter Destinations", FilterLessThan100),
                new MenuItem("2. Top 3 Duration", TopThreeFilter),
                new MenuItem("3. Alphabetical List", SortAlphabeticallyFilter),
                new MenuItem("4. Longest Destinations Filter", LongestDesFilter),
                new MenuItem("5. Check Locations", CheckLocationFilter),
                new MenuItem("6. Exit", Exit)
            };

            Menu menu = new Menu(menuItemList);
            menu.Display();
        }

        public static void Exit()
        {
            Console.WriteLine("Exiting program...");
            Environment.Exit(0);
        }

        // Write Functions for each class to handle the call method inside the Delegate
        public static void FilterLessThan100()
        {
            Console.Clear();
            FilterDestinations.FindFiltered(categories);
        }

        public static void CheckLocationFilter()
        {
            Console.Clear();
            CheckLocation.CheckLoc(categories);
        }

        public static void LongestDesFilter()
        {
            Console.Clear();
            LongestDuration.LongDur(categories);
        }

        public static void SortAlphabeticallyFilter()
        {
            Console.Clear();
            SortByName.AlphabeticalList(categories);
        }

        public static void TopThreeFilter()
        {
            Console.Clear();
            Top3Duration.TopThree(categories);
        }

        public static void Pause()
        {
            Console.ReadKey();
        }
    }
}