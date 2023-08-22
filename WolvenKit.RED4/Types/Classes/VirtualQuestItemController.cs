using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VirtualQuestItemController : inkVirtualCompoundItemController
	{
		[Ordinal(15)] 
		[RED("questItem")] 
		public inkWidgetReference QuestItem
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("data")] 
		public CHandle<VirutalNestedListData> Data
		{
			get => GetPropertyValue<CHandle<VirutalNestedListData>>();
			set => SetPropertyValue<CHandle<VirutalNestedListData>>(value);
		}

		public VirtualQuestItemController()
		{
			QuestItem = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
