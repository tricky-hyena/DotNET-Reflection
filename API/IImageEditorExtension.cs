using System.Drawing;

namespace API
{
    public interface IImageEditorExtension
    {
        string Title { get; }

        string AuthorName { get; }

        string Description { get; }

        Bitmap Transform(Bitmap bitmap);
    }
}
