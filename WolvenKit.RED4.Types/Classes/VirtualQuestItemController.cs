using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VirtualQuestItemController : inkVirtualCompoundItemController
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
	}
}
