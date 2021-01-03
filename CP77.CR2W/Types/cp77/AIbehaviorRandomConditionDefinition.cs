using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorRandomConditionDefinition : AIbehaviorConditionDefinition
	{
		[Ordinal(0)]  [RED("chance")] public CFloat Chance { get; set; }

		public AIbehaviorRandomConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
