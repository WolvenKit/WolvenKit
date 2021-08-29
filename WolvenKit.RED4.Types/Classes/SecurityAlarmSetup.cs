using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SecurityAlarmSetup : RedBaseClass
	{
		private CBool _useSound;
		private CName _alarmSound;

		[Ordinal(0)] 
		[RED("useSound")] 
		public CBool UseSound
		{
			get => GetProperty(ref _useSound);
			set => SetProperty(ref _useSound, value);
		}

		[Ordinal(1)] 
		[RED("alarmSound")] 
		public CName AlarmSound
		{
			get => GetProperty(ref _alarmSound);
			set => SetProperty(ref _alarmSound, value);
		}
	}
}
