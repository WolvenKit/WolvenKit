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
			get
			{
				if (_contact == null)
				{
					_contact = (CHandle<gameJournalPath>) CR2WTypeManager.Create("handle:gameJournalPath", "contact", cr2w, this);
				}
				return _contact;
			}
			set
			{
				if (_contact == value)
				{
					return;
				}
				_contact = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("addContact")] 
		public CBool AddContact
		{
			get
			{
				if (_addContact == null)
				{
					_addContact = (CBool) CR2WTypeManager.Create("Bool", "addContact", cr2w, this);
				}
				return _addContact;
			}
			set
			{
				if (_addContact == value)
				{
					return;
				}
				_addContact = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("sendNotification")] 
		public CBool SendNotification
		{
			get
			{
				if (_sendNotification == null)
				{
					_sendNotification = (CBool) CR2WTypeManager.Create("Bool", "sendNotification", cr2w, this);
				}
				return _sendNotification;
			}
			set
			{
				if (_sendNotification == value)
				{
					return;
				}
				_sendNotification = value;
				PropertySet(this);
			}
		}

		public questChangeContactList_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
