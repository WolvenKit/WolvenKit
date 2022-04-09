using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AICTreeNodeSetSplineMovementTargetDefinition : AICTreeNodeDecoratorDefinition
	{
		[Ordinal(1)] 
		[RED("splineNode")] 
		public LibTreeSharedVarReferenceName SplineNode
		{
			get => GetPropertyValue<LibTreeSharedVarReferenceName>();
			set => SetPropertyValue<LibTreeSharedVarReferenceName>(value);
		}

		[Ordinal(2)] 
		[RED("movementTarget")] 
		public LibTreeSharedVarRegistrationName MovementTarget
		{
			get => GetPropertyValue<LibTreeSharedVarRegistrationName>();
			set => SetPropertyValue<LibTreeSharedVarRegistrationName>(value);
		}

		public AICTreeNodeSetSplineMovementTargetDefinition()
		{
			SplineNode = new();
			MovementTarget = new() { Name = "MovementTarget" };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
