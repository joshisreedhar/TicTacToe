using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace TicTacToe.Extensions
{
    public static class ExtenstionMethods
    {
        public static Point GetCoordinates(this Button button)
        {
            string position = button.Name.Split('_')[1];
            return Utils.GetpointRepresentationFromString(position);
        }
    }
}
