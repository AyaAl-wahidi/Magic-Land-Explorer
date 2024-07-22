using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Land_Explorer.Tasks
{
    public class Top3Duration
    {
        public static void TopThree(List<Category> categories)
        {
            var topList = (from Category in categories
                                from destination in Category.destinations
                                orderby destination.GetDuration() descending
                                select destination).Take(3);

            Console.WriteLine("---------------------- The Top Three Longest-Duration Destinations ----------------------");
            int counter = 1;
            foreach (var des in topList)
            {
                Console.WriteLine($"{counter} - Name : {des.Name} \nDuration : {des.Duration}");
                counter++;
            }
        }
    }
}