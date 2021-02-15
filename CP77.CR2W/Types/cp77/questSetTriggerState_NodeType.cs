using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questSetTriggerState_NodeType : questITriggerManagerNodeType
	{
		[Ordinal(0)] [RED("params")] public CArray<questSetTriggerState_NodeTypeParams> Params { get; set; }

		public questSetTriggerState_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
