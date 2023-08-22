using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RadialMenuGameController : gameuiHUDGameController
	{
		[Ordinal(9)] 
		[RED("containerRef")] 
		public inkCompoundWidgetReference ContainerRef
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("highlightRef")] 
		public inkWidgetReference HighlightRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("itemListRef")] 
		public CArray<inkWidgetReference> ItemListRef
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		[Ordinal(12)] 
		[RED("quickSlotsBoard")] 
		public CWeakHandle<gameIBlackboard> QuickSlotsBoard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(13)] 
		[RED("quickSlotsDef")] 
		public CHandle<UI_QuickSlotsDataDef> QuickSlotsDef
		{
			get => GetPropertyValue<CHandle<UI_QuickSlotsDataDef>>();
			set => SetPropertyValue<CHandle<UI_QuickSlotsDataDef>>(value);
		}

		[Ordinal(14)] 
		[RED("inputAxisCallbackId")] 
		public CHandle<redCallbackObject> InputAxisCallbackId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		public RadialMenuGameController()
		{
			ContainerRef = new inkCompoundWidgetReference();
			HighlightRef = new inkWidgetReference();
			ItemListRef = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
