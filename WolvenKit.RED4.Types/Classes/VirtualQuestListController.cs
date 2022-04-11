using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VirtualQuestListController : inkVirtualCompoundItemController
	{
		[Ordinal(15)] 
		[RED("questList")] 
		public inkWidgetReference QuestList
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public VirtualQuestListController()
		{
			QuestList = new();
		}
	}
}
