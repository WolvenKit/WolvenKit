using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NcartTrainLineListInkController : NcartTrainInkControllerBase
	{
		[Ordinal(16)] 
		[RED("LinesList")] 
		public CArray<ncartLineListDef> LinesList
		{
			get => GetPropertyValue<CArray<ncartLineListDef>>();
			set => SetPropertyValue<CArray<ncartLineListDef>>(value);
		}

		[Ordinal(17)] 
		[RED("ActiveMetroLineNumberFactName")] 
		public CName ActiveMetroLineNumberFactName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(18)] 
		[RED("ActiveMetroStationNumberFactName")] 
		public CName ActiveMetroStationNumberFactName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(19)] 
		[RED("MetroStoppingFactName")] 
		public CName MetroStoppingFactName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(20)] 
		[RED("MetroReverseDirectionFact")] 
		public CName MetroReverseDirectionFact
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(21)] 
		[RED("root")] 
		public CWeakHandle<inkCompoundWidget> Root
		{
			get => GetPropertyValue<CWeakHandle<inkCompoundWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCompoundWidget>>(value);
		}

		[Ordinal(22)] 
		[RED("questsSystem")] 
		public CWeakHandle<questQuestsSystem> QuestsSystem
		{
			get => GetPropertyValue<CWeakHandle<questQuestsSystem>>();
			set => SetPropertyValue<CWeakHandle<questQuestsSystem>>(value);
		}

		[Ordinal(23)] 
		[RED("activeStationListenerId")] 
		public CUInt32 ActiveStationListenerId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(24)] 
		[RED("activeLineListenerId")] 
		public CUInt32 ActiveLineListenerId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(25)] 
		[RED("StopListenerId")] 
		public CUInt32 StopListenerId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(26)] 
		[RED("StationListSetUp")] 
		public CBool StationListSetUp
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(27)] 
		[RED("lastDestination")] 
		public CInt32 LastDestination
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(28)] 
		[RED("currentActiveStation")] 
		public CInt32 CurrentActiveStation
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(29)] 
		[RED("activeStationWidget")] 
		public CInt32 ActiveStationWidget
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(30)] 
		[RED("ncartLogo")] 
		public inkImageWidgetReference NcartLogo
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(31)] 
		[RED("ncartLogoDeco")] 
		public inkImageWidgetReference NcartLogoDeco
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(32)] 
		[RED("ncartLogoDecoFrame1")] 
		public inkImageWidgetReference NcartLogoDecoFrame1
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(33)] 
		[RED("ncartLogoDecoFrame2")] 
		public inkImageWidgetReference NcartLogoDecoFrame2
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(34)] 
		[RED("ncartLogoDecoFrame3")] 
		public inkImageWidgetReference NcartLogoDecoFrame3
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(35)] 
		[RED("ncartLogoDecoFrame4")] 
		public inkImageWidgetReference NcartLogoDecoFrame4
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(36)] 
		[RED("line_loop_symbol")] 
		public inkImageWidgetReference Line_loop_symbol
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(37)] 
		[RED("ncartDecoAccent1")] 
		public inkImageWidgetReference NcartDecoAccent1
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(38)] 
		[RED("ncartDecoAccent2")] 
		public inkImageWidgetReference NcartDecoAccent2
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(39)] 
		[RED("ncartDecoAccent3")] 
		public inkImageWidgetReference NcartDecoAccent3
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(40)] 
		[RED("ncartDecoAccent4")] 
		public inkImageWidgetReference NcartDecoAccent4
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(41)] 
		[RED("ncartTextLogo")] 
		public inkImageWidgetReference NcartTextLogo
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(42)] 
		[RED("ncartDirectionArrowsList")] 
		public inkHorizontalPanelWidgetReference NcartDirectionArrowsList
		{
			get => GetPropertyValue<inkHorizontalPanelWidgetReference>();
			set => SetPropertyValue<inkHorizontalPanelWidgetReference>(value);
		}

		[Ordinal(43)] 
		[RED("ncartLineStationList")] 
		public inkHorizontalPanelWidgetReference NcartLineStationList
		{
			get => GetPropertyValue<inkHorizontalPanelWidgetReference>();
			set => SetPropertyValue<inkHorizontalPanelWidgetReference>(value);
		}

		[Ordinal(44)] 
		[RED("cachedLine")] 
		public CUInt32 CachedLine
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public NcartTrainLineListInkController()
		{
			LinesList = new();
			LastDestination = -1;
			CurrentActiveStation = -1;
			NcartLogo = new inkImageWidgetReference();
			NcartLogoDeco = new inkImageWidgetReference();
			NcartLogoDecoFrame1 = new inkImageWidgetReference();
			NcartLogoDecoFrame2 = new inkImageWidgetReference();
			NcartLogoDecoFrame3 = new inkImageWidgetReference();
			NcartLogoDecoFrame4 = new inkImageWidgetReference();
			Line_loop_symbol = new inkImageWidgetReference();
			NcartDecoAccent1 = new inkImageWidgetReference();
			NcartDecoAccent2 = new inkImageWidgetReference();
			NcartDecoAccent3 = new inkImageWidgetReference();
			NcartDecoAccent4 = new inkImageWidgetReference();
			NcartTextLogo = new inkImageWidgetReference();
			NcartDirectionArrowsList = new inkHorizontalPanelWidgetReference();
			NcartLineStationList = new inkHorizontalPanelWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
