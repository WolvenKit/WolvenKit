using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class EventsFilters : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("incomingEventsFilter")] 
		public CEnum<EFilterType> IncomingEventsFilter
		{
			get => GetPropertyValue<CEnum<EFilterType>>();
			set => SetPropertyValue<CEnum<EFilterType>>(value);
		}

		[Ordinal(1)] 
		[RED("outgoingEventsFilter")] 
		public CEnum<EFilterType> OutgoingEventsFilter
		{
			get => GetPropertyValue<CEnum<EFilterType>>();
			set => SetPropertyValue<CEnum<EFilterType>>(value);
		}

		public EventsFilters()
		{
			IncomingEventsFilter = Enums.EFilterType.ALLOW_ALL;
			OutgoingEventsFilter = Enums.EFilterType.ALLOW_ALL;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
