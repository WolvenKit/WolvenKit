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
			get
			{
				if (_debugIsBlinkOn == null)
				{
					_debugIsBlinkOn = (CBool) CR2WTypeManager.Create("Bool", "debugIsBlinkOn", cr2w, this);
				}
				return _debugIsBlinkOn;
			}
			set
			{
				if (_debugIsBlinkOn == value)
				{
					return;
				}
				_debugIsBlinkOn = value;
				PropertySet(this);
			}
		}

		[Ordinal(93)] 
		[RED("triggeredAlarmID")] 
		public gameDelayID TriggeredAlarmID
		{
			get
			{
				if (_triggeredAlarmID == null)
				{
					_triggeredAlarmID = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "triggeredAlarmID", cr2w, this);
				}
				return _triggeredAlarmID;
			}
			set
			{
				if (_triggeredAlarmID == value)
				{
					return;
				}
				_triggeredAlarmID = value;
				PropertySet(this);
			}
		}

		[Ordinal(94)] 
		[RED("blinkInterval")] 
		public CFloat BlinkInterval
		{
			get
			{
				if (_blinkInterval == null)
				{
					_blinkInterval = (CFloat) CR2WTypeManager.Create("Float", "blinkInterval", cr2w, this);
				}
				return _blinkInterval;
			}
			set
			{
				if (_blinkInterval == value)
				{
					return;
				}
				_blinkInterval = value;
				PropertySet(this);
			}
		}

		public DoorProximityDetector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
