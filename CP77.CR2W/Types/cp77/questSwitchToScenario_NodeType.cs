using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questSwitchToScenario_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)]  [RED("endScenarioName")] public CName EndScenarioName { get; set; }
		[Ordinal(1)]  [RED("forceOpenDuringFadeout")] public CBool ForceOpenDuringFadeout { get; set; }
		[Ordinal(2)]  [RED("startScenarioName")] public CName StartScenarioName { get; set; }
		[Ordinal(3)]  [RED("userData")] public CHandle<inkUserData> UserData { get; set; }

		public questSwitchToScenario_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
