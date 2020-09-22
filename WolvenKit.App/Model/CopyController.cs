using System.Collections.Generic;
using WolvenKit.CR2W;

namespace WolvenKit.App.Model
{
    public static class CopyController
    {
        public static List<IEditableVariable> Source { get; set; }
        public static IEditableVariable Target { get; set; }
    }
}