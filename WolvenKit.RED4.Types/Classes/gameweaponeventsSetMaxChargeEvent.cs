using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameweaponeventsSetMaxChargeEvent : redEvent
	{
		private CFloat _maxCharge;

		[Ordinal(0)] 
		[RED("maxCharge")] 
		public CFloat MaxCharge
		{
			get => GetProperty(ref _maxCharge);
			set => SetProperty(ref _maxCharge, value);
		}

		public gameweaponeventsSetMaxChargeEvent()
		{
			_maxCharge = 100.000000F;
		}
	}
}
