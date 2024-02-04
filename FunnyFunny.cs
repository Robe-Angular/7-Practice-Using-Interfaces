using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_Practice_Using_Interfaces
{
    class FunnyFunny : IClown
    {
        protected string funnyThing;

        public FunnyFunny(string funnyThing)
        {
            this.funnyThing = funnyThing;
        }
        
        public string FunnyThingIHave {
            get { return $"Honk honk! I have a {funnyThing}"; }
        }

        public void Honk()
        {
            MessageBox.Show(FunnyThingIHave);
        }
    }
}
