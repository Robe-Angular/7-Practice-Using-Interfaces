﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Practice_Using_Interfaces
{
    interface IScaryClown:IClown
    {
        string ScaryThingIHave { get; }
        void ScareLittleChildren();
    }
}
