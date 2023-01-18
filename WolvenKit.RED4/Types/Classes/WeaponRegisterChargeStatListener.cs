using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class WeaponRegisterChargeStatListener : redEvent
	{
		[Ordinal(0)] 
		[RED("register")] 
		public CBool Register
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public WeaponRegisterChargeStatListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
