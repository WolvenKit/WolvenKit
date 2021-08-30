using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class minimapuiSettings : RedBaseClass
	{
		private CFloat _showTime;
		private CFloat _hideTime;

		[Ordinal(0)] 
		[RED("showTime")] 
		public CFloat ShowTime
		{
			get => GetProperty(ref _showTime);
			set => SetProperty(ref _showTime, value);
		}

		[Ordinal(1)] 
		[RED("hideTime")] 
		public CFloat HideTime
		{
			get => GetProperty(ref _hideTime);
			set => SetProperty(ref _hideTime, value);
		}

		public minimapuiSettings()
		{
			_showTime = 0.300000F;
			_hideTime = 0.250000F;
		}
	}
}
