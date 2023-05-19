using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topics.Events
{
    public class EventsAnatomy
    {
        public EventsAnatomy()
        {
            _labels = new List<string>
            {
                "trying to shoot target 1",
                "trying to shoot target 2",
                "trying to shoot target 3",
                "trying to shoot target 4",
                "trying to shoot target 5",
                "trying to shoot target 6",
                "trying to shoot target 7",
                "trying to shoot target 8",
                "trying to shoot target 9",
                "trying to shoot target 10"
            };
        }
        public static void RUn()
        {
            var obj = new EventsAnatomy();
        }
        private List<string> _labels;

        //public delegate void Shoot(object sender, ShootEventResulArgs e);
        //public event Shoot ShootEvent;
        public event EventHandler<ShootEventResulArgs> ShootEvent;
        public delegate void Missed(object sender, ShootEventResulArgs e);
        public event Missed ShootMisses;
        public void StartShoot()
        {

                for (int i = 0; i < _labels.Count; i++)
                {
                    if (i % 2 == 0)
                    {
                        ShootEvent?.Invoke(this, new ShootEventResulArgs(_labels[i], i + 1));
                    }
                    else
                    {
                        ShootMisses?.Invoke(this, new ShootEventResulArgs(_labels[i], i + 1));
                    }

                    System.Threading.Thread.Sleep(1000);
                }
        }
    }
}
