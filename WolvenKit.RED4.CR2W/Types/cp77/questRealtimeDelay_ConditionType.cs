using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questRealtimeDelay_ConditionType : questITimeConditionType
	{
		private CUInt32 _hours;
		private CUInt32 _minutes;
		private CUInt32 _seconds;
		private CUInt32 _miliseconds;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
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

		[Ordinal(2)] 
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

		[Ordinal(3)] 
		[RED("miliseconds")] 
		public CUInt32 Miliseconds
		{
			get
			{
				if (_miliseconds == null)
				{
					_miliseconds = (CUInt32) CR2WTypeManager.Create("Uint32", "miliseconds", cr2w, this);
				}
				return _miliseconds;
			}
			set
			{
				if (_miliseconds == value)
				{
					return;
				}
				_miliseconds = value;
				PropertySet(this);
			}
		}

		public questRealtimeDelay_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
