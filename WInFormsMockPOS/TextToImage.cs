using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WInFormsMockPOS
{
    class TextToImage
    {
        public static Image DrawText(String text, Font font, Color textColor, Color backColor)
        {
            // Creating dummy bitmap to get the graphics object
            Image img = new Bitmap(1, 1);
            Graphics drawing = Graphics.FromImage(img);

            // Measure the string to see how big the image will be
            SizeF textSize = drawing.MeasureString(text, font);

            // get rid of the dummy values
            img.Dispose();
            drawing.Dispose();

            // Paint the background
            drawing.Clear(backColor);

            // Create the brush for the text
            Brush textBrush = new SolidBrush(textColor);

            drawing.DrawString(text, font, textBrush, 0, 0);

            drawing.Save();

            textBrush.Dispose();
            drawing.Dispose();

            return img;
        }
    }
}
