using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestListItemHoverOverEvent : redEvent
	{
		private CBool _isQuestResolved;

		[Ordinal(0)] 
		[RED("isQuestResolved")] 
		public CBool IsQuestResolved
		{
			get
			{
				if (_isQuestResolved == null)
				{
					_isQuestResolved = (CBool) CR2WTypeManager.Create("Bool", "isQuestResolved", cr2w, this);
				}
				return _isQuestResolved;
			}
			set
			{
				if (_isQuestResolved == value)
				{
					return;
				}
				_isQuestResolved = value;
				PropertySet(this);
			}
		}

		public QuestListItemHoverOverEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
