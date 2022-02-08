using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DoorProximityDetector : ProximityDetector
	{
		[Ordinal(93)] 
		[RED("debugIsBlinkOn")] 
		public CBool DebugIsBlinkOn
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(94)] 
		[RED("triggeredAlarmID")] 
		public gameDelayID TriggeredAlarmID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(95)] 
		[RED("blinkInterval")] 
		public CFloat BlinkInterval
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public DoorProximityDetector()
		{
			ControllerTypeName = "DoorProximityDetectorController";
			ScanningAreaName = "scanningArea";
			SurroundingAreaName = "surroundingArea";
			TriggeredAlarmID = new();
			BlinkInterval = 2.000000F;
		}
	}
}
