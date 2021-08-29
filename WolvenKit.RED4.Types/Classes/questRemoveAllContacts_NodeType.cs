using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questRemoveAllContacts_NodeType : questIPhoneManagerNodeType
	{
		private CArray<CHandle<gameJournalPath>> _excludedContacts;

		[Ordinal(0)] 
		[RED("excludedContacts")] 
		public CArray<CHandle<gameJournalPath>> ExcludedContacts
		{
			get => GetProperty(ref _excludedContacts);
			set => SetProperty(ref _excludedContacts, value);
		}
	}
}
