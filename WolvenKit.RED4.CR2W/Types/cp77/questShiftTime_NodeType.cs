using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questShiftTime_NodeType : questITimeManagerNodeType
	{
		private CEnum<questETimeShiftType> _timeShiftType;
		private CBool _preventVisualGlitch;
		private CUInt32 _hours;
		private CUInt32 _minutes;
		private CUInt32 _seconds;

		[Ordinal(0)] 
		[RED("timeShiftType")] 
		public CEnum<questETimeShiftType> TimeShiftType
		{
			get
			{
				if (_timeShiftType == null)
				{
					_timeShiftType = (CEnum<questETimeShiftType>) CR2WTypeManager.Create("questETimeShiftType", "timeShiftType", cr2w, this);
				}
				return _timeShiftType;
			}
			set
			{
				if (_timeShiftType == value)
				{
					return;
				}
				_timeShiftType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("preventVisualGlitch")] 
		public CBool PreventVisualGlitch
		{
			get
			{
				if (_preventVisualGlitch == null)
				{
					_preventVisualGlitch = (CBool) CR2WTypeManager.Create("Bool", "preventVisualGlitch", cr2w, this);
				}
				return _preventVisualGlitch;
			}
			set
			{
				if (_preventVisualGlitch == value)
				{
					return;
				}
				_preventVisualGlitch = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("hours")] 
		public CUInt32 Hours
		{
			get
			{
				if (_hours == null)
				{
					_hours = (CUInt32) CR2WTypeManager.Create("Uint32", "hours", cr2w, this);
				}
				return _hours;
			}
			set
			{
				if (_hours == value)
				{
					return;
				}
				_hours = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("minutes")] 
		public CUInt32 Minutes
		{
			get
			{
				if (_minutes == null)
				{
					_minutes = (CUInt32) CR2WTypeManager.Create("Uint32", "minutes", cr2w, this);
				}
				return _minutes;
			}
			set
			{
				if (_minutes == value)
				{
					return;
				}
				_minutes = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("seconds")] 
		public CUInt32 Seconds
		{
			get
			{
				if (_seconds == null)
				{
					_seconds = (CUInt32) CR2WTypeManager.Create("Uint32", "seconds", cr2w, this);
				}
				return _seconds;
			}
			set
			{
				if (_seconds == value)
				{
					return;
				}
				_seconds = value;
				PropertySet(this);
			}
		}

		public questShiftTime_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
