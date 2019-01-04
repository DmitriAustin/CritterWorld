﻿using SCG.TurboSprite;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CritterWorld
{
    public class Gift : BitmapSprite
    {
        public Gift(int x, int y) : base((Bitmap)Image.FromFile("Images/gift.png"))
        {
            Position = new Point(x, y);
        }
    }

}
