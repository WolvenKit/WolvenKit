using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W3Edit.CR2W;
using W3Edit.CR2W.Editors;
using W3Edit.CR2W.Types;

namespace W3Edit
{
    public class CopyController
    {
        public static List<IEditableVariable> VariableTargets { get; set; }
        public static List<CR2WChunk> ChunkList { get; set; }
    }
}
