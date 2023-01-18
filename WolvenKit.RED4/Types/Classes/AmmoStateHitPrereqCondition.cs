using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AmmoStateHitPrereqCondition : BaseHitPrereqCondition
	{
		[Ordinal(3)] 
		[RED("valueToListen")] 
		public CEnum<EMagazineAmmoState> ValueToListen
		{
			get => GetPropertyValue<CEnum<EMagazineAmmoState>>();
			set => SetPropertyValue<CEnum<EMagazineAmmoState>>(value);
		}

		public AmmoStateHitPrereqCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
