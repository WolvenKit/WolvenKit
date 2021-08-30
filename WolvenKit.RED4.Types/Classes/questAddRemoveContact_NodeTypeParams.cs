using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questAddRemoveContact_NodeTypeParams : RedBaseClass
	{
		private CName _contact;
		private CBool _addContact;

		[Ordinal(0)] 
		[RED("contact")] 
		public CName Contact
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

		public questAddRemoveContact_NodeTypeParams()
		{
			_addContact = true;
		}
	}
}
