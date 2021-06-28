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
			get => GetProperty(ref _incomingEventsFilter);
			set => SetProperty(ref _incomingEventsFilter, value);
		}

		[Ordinal(1)] 
		[RED("outgoingEventsFilter")] 
		public CEnum<EFilterType> OutgoingEventsFilter
		{
			get => GetProperty(ref _outgoingEventsFilter);
			set => SetProperty(ref _outgoingEventsFilter, value);
		}

		public EventsFilters(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
