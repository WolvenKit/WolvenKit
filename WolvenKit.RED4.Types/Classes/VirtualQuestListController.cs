using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VirtualQuestListController : inkVirtualCompoundItemController
	{
		private inkWidgetReference _questList;

		[Ordinal(15)] 
		[RED("questList")] 
		public inkWidgetReference QuestList
		{
			get => GetProperty(ref _questList);
			set => SetProperty(ref _questList, value);
		}
	}
}
