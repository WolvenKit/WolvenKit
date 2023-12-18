using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MeleeThrowReloadEvents : MeleeEventsTransition
	{
		[Ordinal(2)] 
		[RED("isSwitchingWeapon")] 
		public CBool IsSwitchingWeapon
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public MeleeThrowReloadEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
