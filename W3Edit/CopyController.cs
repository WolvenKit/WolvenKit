using System.Collections.Generic;
using W3Edit.CR2W;
using W3Edit.CR2W.Editors;

namespace W3Edit
{
    public class CopyController
    {
        public static List<IEditableVariable> VariableTargets { get; set; }
        public static List<CR2WChunk> ChunkList { get; set; }
    }
}