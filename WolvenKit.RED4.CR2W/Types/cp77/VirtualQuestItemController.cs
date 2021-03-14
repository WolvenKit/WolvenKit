using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VirtualQuestItemController : inkVirtualCompoundItemController
	{
		private inkWidgetReference _questItem;
		private CHandle<VirutalNestedListData> _data;

		[Ordinal(15)] 
		[RED("questItem")] 
		public inkWidgetReference QuestItem
		{
			get
			{
				if (_questItem == null)
				{
					_questItem = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "questItem", cr2w, this);
				}
				return _questItem;
			}
			set
			{
				if (_questItem == value)
				{
					return;
				}
				_questItem = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("data")] 
		public CHandle<VirutalNestedListData> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (CHandle<VirutalNestedListData>) CR2WTypeManager.Create("handle:VirutalNestedListData", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		public VirtualQuestItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
