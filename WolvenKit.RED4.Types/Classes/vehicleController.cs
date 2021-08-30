using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehicleController : gameComponent
	{
		private CName _alarmCurve;
		private CFloat _alarmTime;

		[Ordinal(4)] 
		[RED("alarmCurve")] 
		public CName AlarmCurve
		{
			get => GetProperty(ref _alarmCurve);
			set => SetProperty(ref _alarmCurve, value);
		}

		[Ordinal(5)] 
		[RED("alarmTime")] 
		public CFloat AlarmTime
		{
			get => GetProperty(ref _alarmTime);
			set => SetProperty(ref _alarmTime, value);
		}

		public vehicleController()
		{
			_alarmCurve = "default_alarm";
			_alarmTime = 0.500000F;
		}
	}
}
