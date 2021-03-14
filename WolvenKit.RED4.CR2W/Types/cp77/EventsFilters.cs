using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EventsFilters : CVariable
	{
		private CEnum<EFilterType> _incomingEventsFilter;
		private CEnum<EFilterType> _outgoingEventsFilter;

		[Ordinal(0)] 
		[RED("incomingEventsFilter")] 
		public CEnum<EFilterType> IncomingEventsFilter
		{
			get
			{
				if (_incomingEventsFilter == null)
				{
					_incomingEventsFilter = (CEnum<EFilterType>) CR2WTypeManager.Create("EFilterType", "incomingEventsFilter", cr2w, this);
				}
				return _incomingEventsFilter;
			}
			set
			{
				if (_incomingEventsFilter == value)
				{
					return;
				}
				_incomingEventsFilter = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("outgoingEventsFilter")] 
		public CEnum<EFilterType> OutgoingEventsFilter
		{
			get
			{
				if (_outgoingEventsFilter == null)
				{
					_outgoingEventsFilter = (CEnum<EFilterType>) CR2WTypeManager.Create("EFilterType", "outgoingEventsFilter", cr2w, this);
				}
				return _outgoingEventsFilter;
			}
			set
			{
				if (_outgoingEventsFilter == value)
				{
					return;
				}
				_outgoingEventsFilter = value;
				PropertySet(this);
			}
		}

		public EventsFilters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
