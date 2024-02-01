using System.Drawing;

namespace API
{
    internal interface IImageEditorExtension
    {
        string Title { get; }

        string AuthorName { get; }

        string Description { get; }

        void Transform(Bitmap bitmap);
    }
}
