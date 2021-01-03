using System.Collections.Generic;

namespace WolvenKit.Model
{
    using CR2W;

    public static class CopyController
    {
        public static List<IEditableVariable> Source { get; set; }
        public static IEditableVariable Target { get; set; }
    }
}