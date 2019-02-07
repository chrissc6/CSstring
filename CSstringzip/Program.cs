using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSstringzip
{
    class Program
    {

        static void Main(string[] args)
        {
            //string zip = "12345";
            Console.WriteLine("Enter zipcode: ");
            string zip = Console.ReadLine();
            bool check = ZipCheck(zip);
            Console.WriteLine(check);
        }

        static bool ZipCheck(string zip)
        {
            int i = zip.Length;

            bool x = zip.All(char.IsDigit);

            if(x == true)
            {
                if (i == 5 || i == 9)
                {
                    return true;
                }
                else return false;
            }
            else
            {
                if (i == 10)
                {
                    string sub = zip.Substring(5, 1);
                    string sub2 = zip.Substring(0, 5);
                    string sub3 = zip.Substring(6, 4);
                    bool y = sub2.All(char.IsDigit);
                    bool z = sub3.All(char.IsDigit);
                    //Console.WriteLine($"{ sub2}, {sub3}");

                    if (sub == "-" && y == true && z == true)
                    {
                        return true;
                    }
                    else return false;
                }
                else return false;
            }
        }
    }
}
