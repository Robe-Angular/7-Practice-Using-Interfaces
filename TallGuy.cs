using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _7_Practice_Using_Interfaces
{
    class TallGuy : IClown
    {
        public string Name;
        public int Height;
        public void TalkAboutYourself()
        {
            MessageBox.Show($"My name is {Name} and I'm {Height} inches tall.");
        }
        public string FunnyThingIHave
        {
            get { return "Big shoes"; }
        }

        public void Honk()
        {
            MessageBox.Show("Honk honk!");
        }
        
    }
}
