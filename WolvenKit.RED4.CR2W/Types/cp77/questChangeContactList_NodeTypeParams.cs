using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questChangeContactList_NodeTypeParams : CVariable
	{
		private CHandle<gameJournalPath> _contact;
		private CBool _addContact;
		private CBool _sendNotification;

		[Ordinal(0)] 
		[RED("contact")] 
		public CHandle<gameJournalPath> Contact
		{
			get => GetProperty(ref _contact);
			set => SetProperty(ref _contact, value);
		}

		[Ordinal(1)] 
		[RED("addContact")] 
		public CBool AddContact
		{
			get => GetProperty(ref _addContact);
			set => SetProperty(ref _addContact, value);
		}

		[Ordinal(2)] 
		[RED("sendNotification")] 
		public CBool SendNotification
		{
			get => GetProperty(ref _sendNotification);
			set => SetProperty(ref _sendNotification, value);
		}

		public questChangeContactList_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
