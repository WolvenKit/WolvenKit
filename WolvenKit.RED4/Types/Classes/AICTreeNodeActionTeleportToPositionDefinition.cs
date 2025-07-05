using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AICTreeNodeActionTeleportToPositionDefinition : AICTreeNodeActionDefinition
	{
		[Ordinal(1)] 
		[RED("positionName")] 
		public CName PositionName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("doNavTest")] 
		public CBool DoNavTest
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AICTreeNodeActionTeleportToPositionDefinition()
		{
			PositionName = "MovementTarget";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
