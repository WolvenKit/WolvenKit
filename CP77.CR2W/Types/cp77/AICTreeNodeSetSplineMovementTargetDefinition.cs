using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AICTreeNodeSetSplineMovementTargetDefinition : AICTreeNodeDecoratorDefinition
	{
		[Ordinal(1)] [RED("splineNode")] public LibTreeSharedVarReferenceName SplineNode { get; set; }
		[Ordinal(2)] [RED("movementTarget")] public LibTreeSharedVarRegistrationName MovementTarget { get; set; }

		public AICTreeNodeSetSplineMovementTargetDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
