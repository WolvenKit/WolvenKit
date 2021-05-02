using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DoorProximityDetector : ProximityDetector
	{
		private CBool _debugIsBlinkOn;
		private gameDelayID _triggeredAlarmID;
		private CFloat _blinkInterval;

		[Ordinal(92)] 
		[RED("debugIsBlinkOn")] 
		public CBool DebugIsBlinkOn
		{
			get => GetProperty(ref _debugIsBlinkOn);
			set => SetProperty(ref _debugIsBlinkOn, value);
		}

		[Ordinal(93)] 
		[RED("triggeredAlarmID")] 
		public gameDelayID TriggeredAlarmID
		{
			get => GetProperty(ref _triggeredAlarmID);
			set => SetProperty(ref _triggeredAlarmID, value);
		}

		[Ordinal(94)] 
		[RED("blinkInterval")] 
		public CFloat BlinkInterval
		{
			get => GetProperty(ref _blinkInterval);
			set => SetProperty(ref _blinkInterval, value);
		}

		public DoorProximityDetector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
