using System.Collections.Generic;
using WolvenKit.Common.Model.Cr2w;

namespace WolvenKit.Models
{
    public static class CopyController
    {
        #region Properties

        public static List<IEditableVariable> Source { get; set; }
        public static IEditableVariable Target { get; set; }

        #endregion Properties
    }
}
