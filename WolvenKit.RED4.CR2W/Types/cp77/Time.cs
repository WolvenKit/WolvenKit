using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Time : CVariable
	{
		private CInt32 _days;
		private CInt32 _hours;
		private CInt32 _minutes;

		[Ordinal(0)] 
		[RED("days")] 
		public CInt32 Days
		{
			get
			{
				if (_days == null)
				{
					_days = (CInt32) CR2WTypeManager.Create("Int32", "days", cr2w, this);
				}
				return _days;
			}
			set
			{
				if (_days == value)
				{
					return;
				}
				_days = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("hours")] 
		public CInt32 Hours
		{
			get
			{
				if (_hours == null)
				{
					_hours = (CInt32) CR2WTypeManager.Create("Int32", "hours", cr2w, this);
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

		[Ordinal(2)] 
		[RED("minutes")] 
		public CInt32 Minutes
		{
			get
			{
				if (_minutes == null)
				{
					_minutes = (CInt32) CR2WTypeManager.Create("Int32", "minutes", cr2w, this);
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

		public Time(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
