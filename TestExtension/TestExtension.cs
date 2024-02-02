using API;
using System.Drawing;

namespace TestExtension
{
    [ExtensionVersion(1, 0, 0)]
    public class TestExtension : IImageEditorExtension
    {
        public string Title => "Test Extension";

        public string AuthorName => "No Name";

        public string Description => Title;

        public void Transform(Bitmap bitmap)
        {
            for (int i = 0; i < bitmap.Width; ++i)
                for (int j = 0; j < bitmap.Height / 2; ++j)
                {
                    Color color = bitmap.GetPixel(i, j);
                    bitmap.SetPixel(i, j, bitmap.GetPixel(i, bitmap.Height - j - 1));
                    bitmap.SetPixel(i, bitmap.Height - j - 1, color);
                }
        }
    }
}
