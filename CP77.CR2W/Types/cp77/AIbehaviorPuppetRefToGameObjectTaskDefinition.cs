using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorPuppetRefToGameObjectTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(0)]  [RED("puppetRef")] public CHandle<AIArgumentMapping> PuppetRef { get; set; }
		[Ordinal(1)]  [RED("result")] public CHandle<AIArgumentMapping> Result { get; set; }

		public AIbehaviorPuppetRefToGameObjectTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
