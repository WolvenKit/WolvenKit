using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questChangeContactList_NodeTypeParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("contact")] 
		public CHandle<gameJournalPath> Contact
		{
			get => GetPropertyValue<CHandle<gameJournalPath>>();
			set => SetPropertyValue<CHandle<gameJournalPath>>(value);
		}

		[Ordinal(1)] 
		[RED("addContact")] 
		public CBool AddContact
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("sendNotification")] 
		public CBool SendNotification
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questChangeContactList_NodeTypeParams()
		{
			AddContact = true;
			SendNotification = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
