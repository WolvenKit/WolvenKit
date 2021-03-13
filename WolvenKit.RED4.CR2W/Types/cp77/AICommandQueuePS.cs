using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AICommandQueuePS : gameComponentPS
	{
		[Ordinal(0)] [RED("behaviorArgumentList")] public CArray<CHandle<AIArgumentInstancePS>> BehaviorArgumentList { get; set; }
		[Ordinal(1)] [RED("aiRole")] public CHandle<AIRole> AiRole { get; set; }

		public AICommandQueuePS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
