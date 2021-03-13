using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AICTreeNodeSetSplineMovementTargetDefinition : AICTreeNodeDecoratorDefinition
	{
		[Ordinal(1)] [RED("splineNode")] public LibTreeSharedVarReferenceName SplineNode { get; set; }
		[Ordinal(2)] [RED("movementTarget")] public LibTreeSharedVarRegistrationName MovementTarget { get; set; }

		public AICTreeNodeSetSplineMovementTargetDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
