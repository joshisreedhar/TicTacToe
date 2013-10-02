using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace TicTacToe
{
    public static class Utils
    {
        public static Point GetpointRepresentationFromString(string poisitionalString)
        {
            int x= 0;
            int y =0;

            int.TryParse(poisitionalString.Substring(0, 1),out x);
             int.TryParse(poisitionalString.Substring(1, 1),out y);
            return new Point(x,y );
        }
    }
}
