using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questPhonePickUp_ConditionType : questISystemConditionType
	{
		private CHandle<gameJournalPath> _caller;
		private CHandle<gameJournalPath> _addressee;

		[Ordinal(0)] 
		[RED("caller")] 
		public CHandle<gameJournalPath> Caller
		{
			get
			{
				if (_caller == null)
				{
					_caller = (CHandle<gameJournalPath>) CR2WTypeManager.Create("handle:gameJournalPath", "caller", cr2w, this);
				}
				return _caller;
			}
			set
			{
				if (_caller == value)
				{
					return;
				}
				_caller = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("addressee")] 
		public CHandle<gameJournalPath> Addressee
		{
			get
			{
				if (_addressee == null)
				{
					_addressee = (CHandle<gameJournalPath>) CR2WTypeManager.Create("handle:gameJournalPath", "addressee", cr2w, this);
				}
				return _addressee;
			}
			set
			{
				if (_addressee == value)
				{
					return;
				}
				_addressee = value;
				PropertySet(this);
			}
		}

		public questPhonePickUp_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
