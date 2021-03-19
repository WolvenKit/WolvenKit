using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioVehicleTemperatureSettings : CVariable
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

		public audioVehicleTemperatureSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
