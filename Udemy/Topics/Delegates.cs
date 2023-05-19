using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topics
{
    public class Delegates
    {
        public static void Run()
        {
            var names = new string[] { "Hamid", "Ali", "Mahdi", "Jack", "Jennifer" };
            //var filteredNamesLessThan=FilterNames(names, filterLessThanFive);
            //var filteredNamesEqual=FilterNames(names, filterEqualToFive);
            //var filteredNamesGreater=FilterNames(names, filterGreaterThanFive);
            //var filterNames = FilterNames(names, name => name.Length ==3);

            //Func<string, bool> lessthan = filterLessThanFive;
            //var filteredNamesLessThan = FilterNames(names, lessthan);

            //Func<string, bool> greaterThan = item => item.Length == 5;
            //var filteredNamesEqual = FilterNames(names, greaterThan);

            //var filteredNamesGreater = FilterNames(names, filterGreaterThanFive);
            //var filterNames = FilterNames(names, name => name.Length == 3);

            //Console.WriteLine($"Name with number of characters less than 5 : {string.Join(",", filteredNamesLessThan)}");
            //Console.WriteLine($"Name with number of characters equal to 5 : {string.Join(",", filteredNamesEqual)}");
            //Console.WriteLine($"Name with number of characters greater than 5 : {string.Join(",", filteredNamesGreater)}");
            //Console.WriteLine($"Name with number of characters equal to 3 : {string.Join(",", filterNames)}");

            ////Print p = PrintName;
            //Action<string> p = PrintName;
            //p += PrintName;
            //p += PrintNameTwice;
            //p += PrintName;
            //p += PrintNameTwice;
            //p += PrintName;

            //p -= PrintNameTwice;
            //p("Hamid");
            //var dels = p.GetInvocationList();
            //foreach (var del in p.GetInvocationList())
            //{
            //    Console.WriteLine(del.Method);
            //}

            //Func<double, double, double> SumNumbers = (x, y) => x + y;
            Func<double, double, double> SumNumbers = (x, y) =>
            {
                return x + y;
            };
            Console.WriteLine(SumNumbers(5, 5));

            Action<double, double> SumTwoNumbers = (x, y) =>
            {
                Console.WriteLine($"First Number is {x}");
                Console.WriteLine($"Second Number is {y}");
                Console.WriteLine($"Total is {x + y}");
            };
            SumTwoNumbers(15, 2.3);

            Func<string, bool> filterDel = name => name.Length > 5;
            Func<string[], Func<string, bool>, List<string>> filter = (nam, filterDelegate) =>
            {
                var filteredNames = new List<string>();

                foreach (var name in names)
                {
                    if (filterDelegate(name))
                    {
                        filteredNames.Add(name);
                    }
                }
                return filteredNames;
            };


            var filteredList=filter(names, filterDel);
            Console.WriteLine(string.Join(",",filteredList));
        }


        //public delegate bool Filter(string name);
        //public delegate void Print(string name);
        private static bool filterLessThanFive(string name)
        {
            return name.Length < 5;
        }
        private static bool filterGreaterThanFive(string name)
        {
            return name.Length > 5;
        }

        private static bool filterEqualToFive(string name)
        {
            return name.Length == 5;
        }

        private static List<string> FilterNames(string[] names, Func<string, bool> filter)
        {
            var filteredNames = new List<string>();

            foreach (var name in names)
            {
                if (filter(name))
                {
                    filteredNames.Add(name);
                }
            }
            return filteredNames;
        }

        private static void PrintName(string name)
        {
            Console.WriteLine(name);
        }

        private static void PrintNameTwice(string name)
        {
            Console.WriteLine(name + "1");
            Console.WriteLine(name + "1");
        }

    }
}
