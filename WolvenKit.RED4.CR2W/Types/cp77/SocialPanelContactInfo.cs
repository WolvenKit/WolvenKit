using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SocialPanelContactInfo : CVariable
	{
		private CInt32 _hash;
		private wCHandle<gameJournalContact> _contact;

		[Ordinal(0)] 
		[RED("Hash")] 
		public CInt32 Hash
		{
			get
			{
				if (_hash == null)
				{
					_hash = (CInt32) CR2WTypeManager.Create("Int32", "Hash", cr2w, this);
				}
				return _hash;
			}
			set
			{
				if (_hash == value)
				{
					return;
				}
				_hash = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("Contact")] 
		public wCHandle<gameJournalContact> Contact
		{
			get
			{
				if (_contact == null)
				{
					_contact = (wCHandle<gameJournalContact>) CR2WTypeManager.Create("whandle:gameJournalContact", "Contact", cr2w, this);
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

		public SocialPanelContactInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
