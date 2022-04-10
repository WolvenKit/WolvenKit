using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AmmoStateHitTriggeredPrereq : HitTriggeredPrereq
	{
		[Ordinal(5)] 
		[RED("valueToListen")] 
		public CEnum<EMagazineAmmoState> ValueToListen
		{
			get => GetPropertyValue<CEnum<EMagazineAmmoState>>();
			set => SetPropertyValue<CEnum<EMagazineAmmoState>>(value);
		}

		public AmmoStateHitTriggeredPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
