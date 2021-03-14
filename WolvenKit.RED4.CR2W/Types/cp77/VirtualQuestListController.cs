using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VirtualQuestListController : inkVirtualCompoundItemController
	{
		private inkWidgetReference _questList;

		[Ordinal(15)] 
		[RED("questList")] 
		public inkWidgetReference QuestList
		{
			get
			{
				if (_questList == null)
				{
					_questList = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "questList", cr2w, this);
				}
				return _questList;
			}
			set
			{
				if (_questList == value)
				{
					return;
				}
				_questList = value;
				PropertySet(this);
			}
		}

		public VirtualQuestListController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
