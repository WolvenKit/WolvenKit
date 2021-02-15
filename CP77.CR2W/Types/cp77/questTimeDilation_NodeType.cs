using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questTimeDilation_NodeType : questIGameManagerNonSignalStoppingNodeType
	{
		[Ordinal(0)] [RED("params")] public CArray<CHandle<questTimeDilation_NodeTypeParam>> Params { get; set; }

		public questTimeDilation_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
