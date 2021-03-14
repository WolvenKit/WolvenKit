using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioDynamicEventsWithInterval : CVariable
	{
		private CArray<CName> _events;
		private CFloat _interval;

		[Ordinal(0)] 
		[RED("events")] 
		public CArray<CName> Events
		{
			get
			{
				if (_events == null)
				{
					_events = (CArray<CName>) CR2WTypeManager.Create("array:CName", "events", cr2w, this);
				}
				return _events;
			}
			set
			{
				if (_events == value)
				{
					return;
				}
				_events = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("interval")] 
		public CFloat Interval
		{
			get
			{
				if (_interval == null)
				{
					_interval = (CFloat) CR2WTypeManager.Create("Float", "interval", cr2w, this);
				}
				return _interval;
			}
			set
			{
				if (_interval == value)
				{
					return;
				}
				_interval = value;
				PropertySet(this);
			}
		}

		public audioDynamicEventsWithInterval(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
