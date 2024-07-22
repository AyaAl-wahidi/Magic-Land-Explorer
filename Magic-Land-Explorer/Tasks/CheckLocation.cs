using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Land_Explorer.Tasks
{
    public class CheckLocation
    {
        public static void CheckLoc(List<Category> categories)
        {
            var check = from Category in categories
                        from destination in Category.destinations
                        where destination.Location == "Fantasyland"
                        select destination;


            Console.WriteLine("---------------------- The Fantasyland Categories ----------------------");
            int counter = 1;
            foreach (var des in check)
            {
                Console.WriteLine($"{counter} - Name : {des.Name} \nType : {des.Type}");
                counter++;
            }
        }
    }
}