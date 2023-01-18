using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SetCurrentGameplayRoleEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("gameplayRole")] 
		public CEnum<EGameplayRole> GameplayRole
		{
			get => GetPropertyValue<CEnum<EGameplayRole>>();
			set => SetPropertyValue<CEnum<EGameplayRole>>(value);
		}

		public SetCurrentGameplayRoleEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
