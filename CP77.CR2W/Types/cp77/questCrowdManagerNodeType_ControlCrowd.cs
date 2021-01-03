using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questCrowdManagerNodeType_ControlCrowd : questICrowdManager_NodeType
	{
		[Ordinal(0)]  [RED("action")] public CEnum<questControlCrowdAction> Action { get; set; }
		[Ordinal(1)]  [RED("debugSource")] public CName DebugSource { get; set; }

		public questCrowdManagerNodeType_ControlCrowd(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
