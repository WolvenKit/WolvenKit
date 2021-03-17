using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AICTreeNodeSetSplineMovementTargetDefinition : AICTreeNodeDecoratorDefinition
	{
		private LibTreeSharedVarReferenceName _splineNode;
		private LibTreeSharedVarRegistrationName _movementTarget;

		[Ordinal(1)] 
		[RED("splineNode")] 
		public LibTreeSharedVarReferenceName SplineNode
		{
			get => GetProperty(ref _splineNode);
			set => SetProperty(ref _splineNode, value);
		}

		[Ordinal(2)] 
		[RED("movementTarget")] 
		public LibTreeSharedVarRegistrationName MovementTarget
		{
			get => GetProperty(ref _movementTarget);
			set => SetProperty(ref _movementTarget, value);
		}

		public AICTreeNodeSetSplineMovementTargetDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
