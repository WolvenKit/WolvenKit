using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorConvertCommandToDynamicWorkspotTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(0)]  [RED("command")] public CHandle<AIArgumentMapping> Command { get; set; }
		[Ordinal(1)]  [RED("outWorkspotData")] public CHandle<AIArgumentMapping> OutWorkspotData { get; set; }

		public AIbehaviorConvertCommandToDynamicWorkspotTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
