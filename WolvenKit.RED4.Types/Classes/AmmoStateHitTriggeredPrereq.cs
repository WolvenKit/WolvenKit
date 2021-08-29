using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AmmoStateHitTriggeredPrereq : HitTriggeredPrereq
	{
		private CEnum<EMagazineAmmoState> _valueToListen;

		[Ordinal(5)] 
		[RED("valueToListen")] 
		public CEnum<EMagazineAmmoState> ValueToListen
		{
			get => GetProperty(ref _valueToListen);
			set => SetProperty(ref _valueToListen, value);
		}
	}
}
