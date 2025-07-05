using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameMuppetInputActionRangedAttack : gameIMuppetInputAction
	{
		[Ordinal(0)] 
		[RED("actionType")] 
		public CEnum<gameMuppetInputActionType> ActionType
		{
			get => GetPropertyValue<CEnum<gameMuppetInputActionType>>();
			set => SetPropertyValue<CEnum<gameMuppetInputActionType>>(value);
		}

		public gameMuppetInputActionRangedAttack()
		{
			ActionType = Enums.gameMuppetInputActionType.Press;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
