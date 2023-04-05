using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Utilities
{
    public class BasicUtils
    {
        private static Random random = new Random();

        public static Color GetRandomColor() =>
            Color.FromArgb(
                    random.Next(256), random.Next(256), random.Next(256)
                );

        public static Point GetRandomLocationInParent(Size parent, Size child)
            => new Point
            {
                X = random.Next(parent.Width - child.Width),
                Y = random.Next(parent.Height - child.Height)
            };
    }
}
