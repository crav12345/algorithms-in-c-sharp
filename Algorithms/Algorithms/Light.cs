using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Light
    {
        public bool IsOn { get; set; }
        public string Name { get; set; }

        public Light(bool newIsOn, string newName)
        {
            IsOn = newIsOn;
            Name = newName;
        }

        public Light()
        {
            IsOn = false;
            Name = "New Light";
        }
    }
}
