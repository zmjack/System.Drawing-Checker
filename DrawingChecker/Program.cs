using System;
using System.Drawing;

namespace DrawingChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var bitmap = new Bitmap(1, 1))
            using (var graphics = Graphics.FromImage(new Bitmap(1, 1)))
            {
                var fontSize = graphics.MeasureString("Drawing", new Font("Consolas", 11));
                var width = fontSize.Width;
                Console.WriteLine(width);
            }
        }
    }
}
