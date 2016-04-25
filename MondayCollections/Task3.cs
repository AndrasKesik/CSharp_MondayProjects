using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MondayCollections
{
    class Task3
    {
        public static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict["One"] = 1;
            dict["Two"] = 2;
            dict["Three"] = 3;
            dict["Four"] = 4;
            dict["Zero"] = 0;
            dict["Five"] = 5;
            dict["Six"] = 6;
            dict["Seven"] = 7;
            dict["Eight"] = 8;
            dict["Nine"] = 9;

            string ourNumber = "three";

            if (dict.ContainsKey(ourNumber))
            {
                Console.WriteLine(dict[ourNumber]);
            }

          
              
        }
    }
}
