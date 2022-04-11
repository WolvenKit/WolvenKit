using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AmmoStateHitTriggeredPrereq : HitTriggeredPrereq
	{
		[Ordinal(5)] 
		[RED("valueToListen")] 
		public CEnum<EMagazineAmmoState> ValueToListen
		{
			get => GetPropertyValue<CEnum<EMagazineAmmoState>>();
			set => SetPropertyValue<CEnum<EMagazineAmmoState>>(value);
		}
	}
}
