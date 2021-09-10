using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AmmoStateHitPrereqCondition : BaseHitPrereqCondition
	{
		[Ordinal(1)] 
		[RED("valueToListen")] 
		public CEnum<EMagazineAmmoState> ValueToListen
		{
			get => GetPropertyValue<CEnum<EMagazineAmmoState>>();
			set => SetPropertyValue<CEnum<EMagazineAmmoState>>(value);
		}
	}
}
