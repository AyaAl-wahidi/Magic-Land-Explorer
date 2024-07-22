using System;
using System.Collections.Generic;
using System.Linq;

namespace Magic_Land_Explorer.Tasks
{
    public class FilterDestinations
    {
        public static void FindFiltered(List<Category> categories)
        {
            var filteredDes = from category in categories
                              from destination in category.destinations
                              where destination.GetDuration() < 100 && destination.GetDuration() > 0
                              select destination;

            Console.WriteLine("---------------------- The List Of (Duration < 100 Minutes) ----------------------");
            foreach (var des in filteredDes)
            {
                Console.WriteLine($"Name: {des.Name}, Duration: {des.Duration}");
            }
        }
    }
}