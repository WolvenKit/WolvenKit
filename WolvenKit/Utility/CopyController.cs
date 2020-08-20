using System.Collections.Generic;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Editors;

namespace WolvenKit
{
    public class CopyController
    {
        public static List<IEditableVariable> VariableTargets { get; set; }
        public static List<CR2WExportWrapper> ChunkList { get; set; }
    }
}