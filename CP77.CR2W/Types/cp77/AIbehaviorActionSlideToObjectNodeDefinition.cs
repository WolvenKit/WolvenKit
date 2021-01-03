using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorActionSlideToObjectNodeDefinition : AIbehaviorActionSlideNodeDefinition
	{
		[Ordinal(0)]  [RED("destination")] public CHandle<AIArgumentMapping> Destination { get; set; }
		[Ordinal(1)]  [RED("offset")] public CHandle<AIArgumentMapping> Offset { get; set; }

		public AIbehaviorActionSlideToObjectNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
