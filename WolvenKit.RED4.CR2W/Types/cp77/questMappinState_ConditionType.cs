using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questMappinState_ConditionType : questIJournalConditionType
	{
		private CHandle<gameJournalPath> _mappinPath;
		private CBool _active;

		[Ordinal(0)] 
		[RED("mappinPath")] 
		public CHandle<gameJournalPath> MappinPath
		{
			get
			{
				if (_mappinPath == null)
				{
					_mappinPath = (CHandle<gameJournalPath>) CR2WTypeManager.Create("handle:gameJournalPath", "mappinPath", cr2w, this);
				}
				return _mappinPath;
			}
			set
			{
				if (_mappinPath == value)
				{
					return;
				}
				_mappinPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("active")] 
		public CBool Active
		{
			get
			{
				if (_active == null)
				{
					_active = (CBool) CR2WTypeManager.Create("Bool", "active", cr2w, this);
				}
				return _active;
			}
			set
			{
				if (_active == value)
				{
					return;
				}
				_active = value;
				PropertySet(this);
			}
		}

		public questMappinState_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
