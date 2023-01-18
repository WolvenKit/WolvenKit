using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questRemoveAllContacts_NodeType : questIPhoneManagerNodeType
	{
		[Ordinal(0)] 
		[RED("excludedContacts")] 
		public CArray<CHandle<gameJournalPath>> ExcludedContacts
		{
			get => GetPropertyValue<CArray<CHandle<gameJournalPath>>>();
			set => SetPropertyValue<CArray<CHandle<gameJournalPath>>>(value);
		}

		public questRemoveAllContacts_NodeType()
		{
			ExcludedContacts = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
