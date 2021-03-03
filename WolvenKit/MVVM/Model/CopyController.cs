using System.Collections.Generic;

namespace WolvenKit.MVVM.Model
{
    using WolvenKit.Common.Model.Cr2w;

    public static class CopyController
    {
        public static List<IEditableVariable> Source { get; set; }
        public static IEditableVariable Target { get; set; }
    }
}
