using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questJournalNotification_ConditionType : questIUIConditionType
	{
		private CHandle<gameJournalPath> _journalPath;

		[Ordinal(0)] 
		[RED("journalPath")] 
		public CHandle<gameJournalPath> JournalPath
		{
			get
			{
				if (_journalPath == null)
				{
					_journalPath = (CHandle<gameJournalPath>) CR2WTypeManager.Create("handle:gameJournalPath", "journalPath", cr2w, this);
				}
				return _journalPath;
			}
			set
			{
				if (_journalPath == value)
				{
					return;
				}
				_journalPath = value;
				PropertySet(this);
			}
		}

		public questJournalNotification_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
