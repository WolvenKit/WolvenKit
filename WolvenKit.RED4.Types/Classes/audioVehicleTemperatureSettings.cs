using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioVehicleTemperatureSettings : RedBaseClass
	{
		private CFloat _rpmThreshold;
		private CFloat _timeToActivateTemperature;
		private CFloat _cooldownTime;

		[Ordinal(0)] 
		[RED("rpmThreshold")] 
		public CFloat RpmThreshold
		{
			get => GetProperty(ref _rpmThreshold);
			set => SetProperty(ref _rpmThreshold, value);
		}

		[Ordinal(1)] 
		[RED("timeToActivateTemperature")] 
		public CFloat TimeToActivateTemperature
		{
			get => GetProperty(ref _timeToActivateTemperature);
			set => SetProperty(ref _timeToActivateTemperature, value);
		}

		[Ordinal(2)] 
		[RED("cooldownTime")] 
		public CFloat CooldownTime
		{
			get => GetProperty(ref _cooldownTime);
			set => SetProperty(ref _cooldownTime, value);
		}

		public audioVehicleTemperatureSettings()
		{
			_rpmThreshold = 3.000000F;
			_timeToActivateTemperature = 8.000000F;
			_cooldownTime = 10.000000F;
		}
	}
}
