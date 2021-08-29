using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DoorProximityDetector : ProximityDetector
	{
		private CBool _debugIsBlinkOn;
		private gameDelayID _triggeredAlarmID;
		private CFloat _blinkInterval;

		[Ordinal(93)] 
		[RED("debugIsBlinkOn")] 
		public CBool DebugIsBlinkOn
		{
			get => GetProperty(ref _debugIsBlinkOn);
			set => SetProperty(ref _debugIsBlinkOn, value);
		}

		[Ordinal(94)] 
		[RED("triggeredAlarmID")] 
		public gameDelayID TriggeredAlarmID
		{
			get => GetProperty(ref _triggeredAlarmID);
			set => SetProperty(ref _triggeredAlarmID, value);
		}

		[Ordinal(95)] 
		[RED("blinkInterval")] 
		public CFloat BlinkInterval
		{
			get => GetProperty(ref _blinkInterval);
			set => SetProperty(ref _blinkInterval, value);
		}
	}
}
