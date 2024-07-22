using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Land_Explorer.Tasks
{
    public class SortByName
    {
        public static void AlphabeticalList(List<Category> categories)
        {
            var alphaList = from Category in categories
                            from destination in Category.destinations
                            orderby destination.Name
                            select destination;

            Console.WriteLine("---------------------- The List Alphabetically ----------------------");
            foreach (var des in alphaList)
            {
                Console.WriteLine($"Name : {des.Name} \nDuration : {des.Duration}");
            }
        }
    }
}