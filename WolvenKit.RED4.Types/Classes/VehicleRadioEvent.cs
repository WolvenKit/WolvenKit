using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VehicleRadioEvent : redEvent
	{
		private CBool _toggle;
		private CBool _setStation;
		private CInt32 _station;

		[Ordinal(0)] 
		[RED("toggle")] 
		public CBool Toggle
		{
			get => GetProperty(ref _toggle);
			set => SetProperty(ref _toggle, value);
		}

		[Ordinal(1)] 
		[RED("setStation")] 
		public CBool SetStation
		{
			get => GetProperty(ref _setStation);
			set => SetProperty(ref _setStation, value);
		}

		[Ordinal(2)] 
		[RED("station")] 
		public CInt32 Station
		{
			get => GetProperty(ref _station);
			set => SetProperty(ref _station, value);
		}
	}
}
