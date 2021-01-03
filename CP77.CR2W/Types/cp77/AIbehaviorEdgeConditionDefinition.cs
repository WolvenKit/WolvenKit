using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorEdgeConditionDefinition : AIbehaviorUnaryConditionDefinition
	{
		[Ordinal(0)]  [RED("fallingEdgeAction")] public CEnum<AIbehaviorEdgeConditionAction> FallingEdgeAction { get; set; }
		[Ordinal(1)]  [RED("initialValue")] public CBool InitialValue { get; set; }
		[Ordinal(2)]  [RED("risingEdgeAction")] public CEnum<AIbehaviorEdgeConditionAction> RisingEdgeAction { get; set; }

		public AIbehaviorEdgeConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
