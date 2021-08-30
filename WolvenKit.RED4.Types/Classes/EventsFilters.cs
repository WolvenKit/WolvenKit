using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EventsFilters : RedBaseClass
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

		public EventsFilters()
		{
			_incomingEventsFilter = new() { Value = Enums.EFilterType.ALLOW_ALL };
			_outgoingEventsFilter = new() { Value = Enums.EFilterType.ALLOW_ALL };
		}
	}
}
