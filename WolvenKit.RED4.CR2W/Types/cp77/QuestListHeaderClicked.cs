using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestListHeaderClicked : redEvent
	{
		private CInt32 _questType;

		[Ordinal(0)] 
		[RED("questType")] 
		public CInt32 QuestType
		{
			get
			{
				if (_questType == null)
				{
					_questType = (CInt32) CR2WTypeManager.Create("Int32", "questType", cr2w, this);
				}
				return _questType;
			}
			set
			{
				if (_questType == value)
				{
					return;
				}
				_questType = value;
				PropertySet(this);
			}
		}

		public QuestListHeaderClicked(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
