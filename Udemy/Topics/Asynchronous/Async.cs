using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topics.Asynchronous
{
    public class Async
    {
        public static void Run()
        {
            //Task<string> t = ConcatenateAsync('c', 200000);
            var time = Stopwatch.StartNew();
            var t = concatenate('c', 200000);

            Console.WriteLine($"Task is completed and the number of characters added is {t.Length}");
            time.Stop();
            Console.WriteLine(time.Elapsed);
        }

        public async static Task<string> ConcatenateAsync(char character, int count)
        {
            //var t = Task<string>.Factory.StartNew(() =>
            //{
            //    return concatenate(character, count);
            //});

            //Console.WriteLine("Task is in progress");
            //var str = await t;
            //return str;

            Console.WriteLine("Task is in progress");
            return await Task<string>.Factory.StartNew(() =>
            {
                return concatenate(character, count);
            });
        }

        private static string concatenate(char character, int count) 
        {
            var text = string.Empty;

            for (int i = 0; i < count; i++)
            {
                text += character;
            }

            return text;
        }
    }
}
