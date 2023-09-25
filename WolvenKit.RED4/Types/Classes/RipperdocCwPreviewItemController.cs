using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RipperdocCwPreviewItemController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("itemIcon")] 
		public inkWidgetReference ItemIcon
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("addIcon")] 
		public inkWidgetReference AddIcon
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("root")] 
		public CWeakHandle<inkWidget> Root
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		public RipperdocCwPreviewItemController()
		{
			ItemIcon = new inkWidgetReference();
			AddIcon = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
