using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ManagerBookLib
{
    public static class Util
    {
        public static string inputID()
        {
            string result = "";
            while (true)
            {
                Console.Write("Enter bookID (saxxx e.g:sa123): ");
                result = Console.ReadLine();
                if (Regex.IsMatch(result, "sa[0-9]{3}"))
                {
                    return result;
                }
            }
        }

        public static string inputName()
        {
            string result = "";
            while (true)
            {
                Console.Write("Enter name: ");
                result = Console.ReadLine();
                if (result.Trim().Length > 0)
                {
                    return result;
                }
                Console.WriteLine("Name can not null");
            }
        }

        public static string inputPublisher()
        {
            string result = "";
            while (true)
            {
                Console.Write("Enter publisher: ");
                result = Console.ReadLine();
                if (result.Trim().Length > 0)
                {
                    return result;
                }
                Console.WriteLine("Publisher need fill");
            }
        }

        public static float inputPrice()
        {
            float result = 0;
            while (true)
            {
                Console.Write("Enter price : ");
                float.TryParse(Console.ReadLine(), out result);
                if (result > 0)
                {
                    return result;
                }
                Console.WriteLine("Price is number and more than zero!!");
            }
        }

    }
}
