using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Switch
    {
        public Light MyLight { get; set; }

        public Switch(Light newLight)
        {
            MyLight = newLight;
        }

        public Switch()
        {
            MyLight = null;
        }

        public void ToggleSwitch()
        {
            MyLight.IsOn = !MyLight.IsOn;
        }
    }
}
