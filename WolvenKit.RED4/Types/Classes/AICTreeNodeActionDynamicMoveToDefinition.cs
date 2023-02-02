using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AICTreeNodeActionDynamicMoveToDefinition : AICTreeNodeActionDefinition
	{
		[Ordinal(1)] 
		[RED("moveType")] 
		public CEnum<moveMovementType> MoveType
		{
			get => GetPropertyValue<CEnum<moveMovementType>>();
			set => SetPropertyValue<CEnum<moveMovementType>>(value);
		}

		[Ordinal(2)] 
		[RED("tolerance")] 
		public CFloat Tolerance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("target")] 
		public CName Target
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("keepDistance")] 
		public CBool KeepDistance
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AICTreeNodeActionDynamicMoveToDefinition()
		{
			Target = "CombatTarget";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
