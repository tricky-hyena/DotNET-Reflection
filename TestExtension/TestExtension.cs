using API;
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Imaging;

namespace TestExtension
{
    [ExtensionVersion(1, 0, 0)]
    public class TestExtension : IImageEditorExtension
    {
        public string Title => "Test Extension";

        public string AuthorName => "No Name";

        public string Description => Title;

        public Bitmap Transform(Bitmap image)
        {
            float b = 2.0f;
            ColorMatrix cm = new ColorMatrix(new float[][]
                {
                    new float[] {b, 0, 0, 0, 0},
                    new float[] {0, b, 0, 0, 0},
                    new float[] {0, 0, b, 0, 0},
                    new float[] {0, 0, 0, 1, 0},
                    new float[] {0, 0, 0, 0, 1},
                });
            ImageAttributes attributes = new ImageAttributes();
            attributes.SetColorMatrix(cm);

            // Draw the image onto the new bitmap while applying the new ColorMatrix.
            Point[] points =
            {
                new Point(0, 0),
                new Point(image.Width, 0),
                new Point(0, image.Height),
            };
            Rectangle rect = new Rectangle(0, 0, image.Width, image.Height);

            // Make the result bitmap.
            Bitmap bm = new Bitmap(image.Width, image.Height);
            using (Graphics gr = Graphics.FromImage(bm))
            {
                gr.DrawImage(image, points, rect, GraphicsUnit.Pixel, attributes);
            }

            return bm;
        }
    }
}
