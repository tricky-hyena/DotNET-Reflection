using System;
using System.Runtime;

namespace API
{
    internal class VersionAttribute : Attribute
    {
        public int Major { get; }

        public int Minor { get; }

        public int Patch { get; }

        public VersionAttribute(int major, int minor, int patch)
        {
            Major = major;
            Minor = minor;
            Patch = patch;
        }
    }
}
