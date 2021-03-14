using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameeventsQuickItemsEvent : redEvent
	{
		private CName _questName;

		[Ordinal(0)] 
		[RED("questName")] 
		public CName QuestName
		{
			get
			{
				if (_questName == null)
				{
					_questName = (CName) CR2WTypeManager.Create("CName", "questName", cr2w, this);
				}
				return _questName;
			}
			set
			{
				if (_questName == value)
				{
					return;
				}
				_questName = value;
				PropertySet(this);
			}
		}

		public gameeventsQuickItemsEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
