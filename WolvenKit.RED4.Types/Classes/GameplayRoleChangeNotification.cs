using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GameplayRoleChangeNotification : redEvent
	{
		[Ordinal(0)] 
		[RED("newRole")] 
		public CEnum<EGameplayRole> NewRole
		{
			get => GetPropertyValue<CEnum<EGameplayRole>>();
			set => SetPropertyValue<CEnum<EGameplayRole>>(value);
		}

		[Ordinal(1)] 
		[RED("oldRole")] 
		public CEnum<EGameplayRole> OldRole
		{
			get => GetPropertyValue<CEnum<EGameplayRole>>();
			set => SetPropertyValue<CEnum<EGameplayRole>>(value);
		}

		public GameplayRoleChangeNotification()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
