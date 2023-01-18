using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questHUDEntryVisibilityEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("dataEntries")] 
		public CArray<questHUDEntryVisibilityData> DataEntries
		{
			get => GetPropertyValue<CArray<questHUDEntryVisibilityData>>();
			set => SetPropertyValue<CArray<questHUDEntryVisibilityData>>(value);
		}

		public questHUDEntryVisibilityEvent()
		{
			DataEntries = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
