using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorDistanceToExpressionDefinition : AIbehaviorPassiveExpressionDefinition
	{
		[Ordinal(0)]  [RED("target")] public CHandle<AIbehaviorExpressionSocket> Target { get; set; }
		[Ordinal(1)]  [RED("tolerance")] public CFloat Tolerance { get; set; }
		[Ordinal(2)]  [RED("updatePeriod")] public CFloat UpdatePeriod { get; set; }

		public AIbehaviorDistanceToExpressionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
