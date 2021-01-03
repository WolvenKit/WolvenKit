using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AICommandQueuePS : gameComponentPS
	{
		[Ordinal(0)]  [RED("aiRole")] public CHandle<AIRole> AiRole { get; set; }
		[Ordinal(1)]  [RED("behaviorArgumentList")] public CArray<CHandle<AIArgumentInstancePS>> BehaviorArgumentList { get; set; }

		public AICommandQueuePS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
