using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topics.Asynchronous
{
    public class TaskExample
    {
        public static void Run() 
        {
            //var t = new Task(Concatenate);
            //t.Start();
            //var t = Task.Run(Concatenate);
            //var t = Task.Factory.StartNew(()=> 
            //{
            //    Concatenate('c', 200000);
            //});

            Task<string> t = Task.Factory.StartNew(() =>
            {
                return ConcatenateWithReturn('c', 200000);
            });
            Console.WriteLine("Task is in progress");
            t.Wait();
            Console.WriteLine($"Task is completed {t.Result}");
        }

        public static void Concatenate(char character, int count) 
        {
            var text = string.Empty;

            for (int i = 0; i < count; i++)
            {
                text += character;
            }
        }

        public static string ConcatenateWithReturn(char character, int count)
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
