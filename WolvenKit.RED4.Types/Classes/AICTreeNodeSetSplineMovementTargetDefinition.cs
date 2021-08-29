using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AICTreeNodeSetSplineMovementTargetDefinition : AICTreeNodeDecoratorDefinition
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
	}
}
