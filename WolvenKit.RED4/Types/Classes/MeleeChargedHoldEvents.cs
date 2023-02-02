using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MeleeChargedHoldEvents : MeleeRumblingEvents
	{
		[Ordinal(1)] 
		[RED("clearWeaponCharge")] 
		public CBool ClearWeaponCharge
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public MeleeChargedHoldEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
