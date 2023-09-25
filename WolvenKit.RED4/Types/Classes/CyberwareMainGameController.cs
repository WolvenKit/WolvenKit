using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CyberwareMainGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("MainViewRoot")] 
		public inkWidgetReference MainViewRoot
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("CyberwareColumnLeft")] 
		public inkCompoundWidgetReference CyberwareColumnLeft
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("CyberwareColumnRight")] 
		public inkCompoundWidgetReference CyberwareColumnRight
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("personalStatsList")] 
		public inkCompoundWidgetReference PersonalStatsList
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("attributesList")] 
		public inkCompoundWidgetReference AttributesList
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("resistancesList")] 
		public inkCompoundWidgetReference ResistancesList
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("TooltipsManagerRef")] 
		public inkWidgetReference TooltipsManagerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("TooltipsManager")] 
		public CWeakHandle<gameuiTooltipsManager> TooltipsManager
		{
			get => GetPropertyValue<CWeakHandle<gameuiTooltipsManager>>();
			set => SetPropertyValue<CWeakHandle<gameuiTooltipsManager>>(value);
		}

		[Ordinal(10)] 
		[RED("InventoryManager")] 
		public CHandle<InventoryDataManagerV2> InventoryManager
		{
			get => GetPropertyValue<CHandle<InventoryDataManagerV2>>();
			set => SetPropertyValue<CHandle<InventoryDataManagerV2>>(value);
		}

		[Ordinal(11)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(12)] 
		[RED("resistanceView")] 
		public CName ResistanceView
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(13)] 
		[RED("statView")] 
		public CName StatView
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(14)] 
		[RED("toolTipOffset")] 
		public inkMargin ToolTipOffset
		{
			get => GetPropertyValue<inkMargin>();
			set => SetPropertyValue<inkMargin>(value);
		}

		[Ordinal(15)] 
		[RED("rawStatsData")] 
		public CArray<gameStatViewData> RawStatsData
		{
			get => GetPropertyValue<CArray<gameStatViewData>>();
			set => SetPropertyValue<CArray<gameStatViewData>>(value);
		}

		public CyberwareMainGameController()
		{
			MainViewRoot = new inkWidgetReference();
			CyberwareColumnLeft = new inkCompoundWidgetReference();
			CyberwareColumnRight = new inkCompoundWidgetReference();
			PersonalStatsList = new inkCompoundWidgetReference();
			AttributesList = new inkCompoundWidgetReference();
			ResistancesList = new inkCompoundWidgetReference();
			TooltipsManagerRef = new inkWidgetReference();
			ToolTipOffset = new inkMargin();
			RawStatsData = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
