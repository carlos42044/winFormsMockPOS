using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace WInFormsMockPOS
{
    static class TextToImage
    {
        public static Bitmap CreateImageFromText(string Text)
        {
            // Create the Font object for the image text drawing.
            Font textFont = new Font("Arial", 12, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

            Bitmap ImageObject = new Bitmap(150, 40);
            // Add the anti aliasing or color settings.
            Graphics GraphicsObject = Graphics.FromImage(ImageObject);

            // Set Background color
            //GraphicsObject.Clear(System.Drawing.Color.White);
            // to specify no aliasing
            GraphicsObject.SmoothingMode = SmoothingMode.Default;
            GraphicsObject.TextRenderingHint = TextRenderingHint.SystemDefault;
            GraphicsObject.DrawString(Text, textFont, new SolidBrush(System.Drawing.Color.Black), 0, 0);
            GraphicsObject.Flush();

            return (ImageObject);
        }
    }
}
