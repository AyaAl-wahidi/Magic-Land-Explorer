using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Land_Explorer.Tasks
{
    public class LongestDuration
    {
        public static void LongDur(List<Category> categories)
        {
            var longDuration = (from Category in categories
                                from destination in Category.destinations
                                orderby destination.GetDuration() descending
                                select destination).FirstOrDefault();


            Console.WriteLine("---------------------- The Longest Duration In The List ----------------------");
            Console.WriteLine($"Name : {longDuration.Name} \nDuration : {longDuration.Duration}");
        }
    }
}