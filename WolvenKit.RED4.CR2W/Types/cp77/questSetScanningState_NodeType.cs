using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSetScanningState_NodeType : questIVisionModeNodeType
	{
		[Ordinal(0)] [RED("objectRef")] public gameEntityReference ObjectRef { get; set; }
		[Ordinal(1)] [RED("state")] public CEnum<questScanningState> State { get; set; }

		public questSetScanningState_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
