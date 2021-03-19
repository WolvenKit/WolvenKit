using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questAddRemoveContact_NodeTypeParams : CVariable
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

		public questAddRemoveContact_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
