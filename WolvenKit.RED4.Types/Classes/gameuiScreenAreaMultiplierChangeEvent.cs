using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiScreenAreaMultiplierChangeEvent : redEvent
	{
		private CFloat _screenAreaMultiplier;

		[Ordinal(0)] 
		[RED("screenAreaMultiplier")] 
		public CFloat ScreenAreaMultiplier
		{
			get => GetProperty(ref _screenAreaMultiplier);
			set => SetProperty(ref _screenAreaMultiplier, value);
		}

		public gameuiScreenAreaMultiplierChangeEvent()
		{
			_screenAreaMultiplier = 1.000000F;
		}
	}
}
