using System;
using System.Runtime;

namespace API
{
    internal class ExtensionVersionAttribute : Attribute
    {
        public int Major { get; }

        public int Minor { get; }

        public int Patch { get; }

        public ExtensionVersionAttribute(int major, int minor, int patch)
        {
            Major = major;
            Minor = minor;
            Patch = patch;
        }
    }
}
