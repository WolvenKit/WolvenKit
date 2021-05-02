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
			get => GetProperty(ref _questItem);
			set => SetProperty(ref _questItem, value);
		}

		[Ordinal(16)] 
		[RED("data")] 
		public CHandle<VirutalNestedListData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		public VirtualQuestItemController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
