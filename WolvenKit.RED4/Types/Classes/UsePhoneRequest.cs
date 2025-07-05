using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UsePhoneRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("MessageToOpen")] 
		public CWeakHandle<gameJournalEntry> MessageToOpen
		{
			get => GetPropertyValue<CWeakHandle<gameJournalEntry>>();
			set => SetPropertyValue<CWeakHandle<gameJournalEntry>>(value);
		}

		public UsePhoneRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
