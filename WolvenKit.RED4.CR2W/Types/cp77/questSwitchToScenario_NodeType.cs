using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSwitchToScenario_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)] [RED("startScenarioName")] public CName StartScenarioName { get; set; }
		[Ordinal(1)] [RED("endScenarioName")] public CName EndScenarioName { get; set; }
		[Ordinal(2)] [RED("userData")] public CHandle<inkUserData> UserData { get; set; }
		[Ordinal(3)] [RED("forceOpenDuringFadeout")] public CBool ForceOpenDuringFadeout { get; set; }

		public questSwitchToScenario_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
