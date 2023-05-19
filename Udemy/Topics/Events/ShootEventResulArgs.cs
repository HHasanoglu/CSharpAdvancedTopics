using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topics.Events
{
    public class ShootEventResulArgs:EventArgs
    {
        private string _label;
        private int _number;

        public ShootEventResulArgs(string label, int number)
        {
            _label = label;
            _number = number;
        }

        public string Label { get => _label; set => _label = value; }
        public int Number { get => _number; set => _number = value; }
    }
}
