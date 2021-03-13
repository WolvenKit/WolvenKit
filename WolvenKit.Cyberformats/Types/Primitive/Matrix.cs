using System.IO;using System.Runtime.Serialization;
using CP77.CR2W.Reflection;
using static CP77.CR2W.Types.Enums;
using FastMember;

namespace CP77.CR2W.Types
{
	[REDMeta()]
    [DataContract(Namespace = "")]
    public class CMatrix : CMatrix_
    {
		public CMatrix(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }
    }
}
