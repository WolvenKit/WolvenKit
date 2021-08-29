using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehicleAudioPSData : RedBaseClass
	{
		private CName _activeRadioStation;
		private CFloat _acousticIsolationFactor;
		private CBool _isPlayerVehicleSummoned;

		[Ordinal(0)] 
		[RED("activeRadioStation")] 
		public CName ActiveRadioStation
		{
			get => GetProperty(ref _activeRadioStation);
			set => SetProperty(ref _activeRadioStation, value);
		}

		[Ordinal(1)] 
		[RED("acousticIsolationFactor")] 
		public CFloat AcousticIsolationFactor
		{
			get => GetProperty(ref _acousticIsolationFactor);
			set => SetProperty(ref _acousticIsolationFactor, value);
		}

		[Ordinal(2)] 
		[RED("isPlayerVehicleSummoned")] 
		public CBool IsPlayerVehicleSummoned
		{
			get => GetProperty(ref _isPlayerVehicleSummoned);
			set => SetProperty(ref _isPlayerVehicleSummoned, value);
		}
	}
}
