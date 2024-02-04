using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_Practice_Using_Interfaces
{
    class ScaryScary : FunnyFunny, IScaryClown
    {
        private int numberOfScaryThings;
        public ScaryScary(string funnyThingIHave, int numberOfScaryThings)
            :base(funnyThingIHave)
        {
            this.numberOfScaryThings = numberOfScaryThings;
        }
        public string ScaryThingIHave 
        { get 
            { return $"{numberOfScaryThings} spiders"; } 
        }

        public void ScareLittleChildren()
        {
            MessageBox.Show(funnyThing);
        }
    }
}
