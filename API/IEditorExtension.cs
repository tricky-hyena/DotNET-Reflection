using System.Drawing;

namespace API
{
    internal interface IEditorExtension
    {
        string Title { get; }

        string AuthorName { get; }

        string Description { get; }

        void Transform(Bitmap bitmap);
    }
}
