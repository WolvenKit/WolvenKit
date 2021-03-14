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
			get
			{
				if (_contact == null)
				{
					_contact = (CName) CR2WTypeManager.Create("CName", "contact", cr2w, this);
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

		public questAddRemoveContact_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
