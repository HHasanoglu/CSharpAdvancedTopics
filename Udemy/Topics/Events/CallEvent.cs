using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topics.Events
{
    public class CallEvent
    {
        public static void Run() 
        {
            var eventAnatomy = new EventsAnatomy();
            //eventAnatomy.ShootEvent += EventAnatomy_ShootEvent;
            //eventAnatomy.ShootMisses += EventAnatomy_ShootMisses;
            eventAnatomy.StartShoot();
        }

        private static void EventAnatomy_ShootMisses(object sender, ShootEventResulArgs e)
        {
            Console.WriteLine($"{e.Label} Target with the number {e.Number} is missed");
        }

        private static void EventAnatomy_ShootEvent(object sender, ShootEventResulArgs e)
        {
            Console.WriteLine($"{e.Label} Target with the number {e.Number} is hit");
        }
    }
}
