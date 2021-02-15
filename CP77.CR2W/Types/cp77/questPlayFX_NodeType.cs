using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questPlayFX_NodeType : questIFXManagerNodeType
	{
		[Ordinal(0)] [RED("params")] public CArray<questPlayFX_NodeTypeParams> Params { get; set; }

		public questPlayFX_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
