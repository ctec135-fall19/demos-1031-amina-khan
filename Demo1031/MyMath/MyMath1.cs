﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMath
{
    public class MyMath1
    {
        public static byte Add(byte x, byte y)
        {            
            checked
            {
                byte b = (byte)(x + y);
                return b;
            }
            //return (byte)(x + y);
            //return b;
        }
    }
}
