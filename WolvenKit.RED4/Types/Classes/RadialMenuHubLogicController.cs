using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RadialMenuHubLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("menuObject")] 
		public inkWidgetReference MenuObject
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("btnCrafting")] 
		public inkWidgetReference BtnCrafting
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("btnPerks")] 
		public inkWidgetReference BtnPerks
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("btnStats")] 
		public inkWidgetReference BtnStats
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("btnInventory")] 
		public inkWidgetReference BtnInventory
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("btnBackpack")] 
		public inkWidgetReference BtnBackpack
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("btnCyberware")] 
		public inkWidgetReference BtnCyberware
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("btnMap")] 
		public inkWidgetReference BtnMap
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("btnJournal")] 
		public inkWidgetReference BtnJournal
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("btnPhone")] 
		public inkWidgetReference BtnPhone
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("btnTarot")] 
		public inkWidgetReference BtnTarot
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("btnShard")] 
		public inkWidgetReference BtnShard
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("btnCodex")] 
		public inkWidgetReference BtnCodex
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("panelInventory")] 
		public inkWidgetReference PanelInventory
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("panelMap")] 
		public inkWidgetReference PanelMap
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("panelJournal")] 
		public inkWidgetReference PanelJournal
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("panelCharacter")] 
		public inkWidgetReference PanelCharacter
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("mouseCollider")] 
		public inkWidgetReference MouseCollider
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("debugText")] 
		public inkTextWidgetReference DebugText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("menusData")] 
		public CHandle<MenuDataBuilder> MenusData
		{
			get => GetPropertyValue<CHandle<MenuDataBuilder>>();
			set => SetPropertyValue<CHandle<MenuDataBuilder>>(value);
		}

		[Ordinal(21)] 
		[RED("tooltipsManager")] 
		public CWeakHandle<gameuiTooltipsManager> TooltipsManager
		{
			get => GetPropertyValue<CWeakHandle<gameuiTooltipsManager>>();
			set => SetPropertyValue<CWeakHandle<gameuiTooltipsManager>>(value);
		}

		[Ordinal(22)] 
		[RED("tooltipsManagerRef")] 
		public inkWidgetReference TooltipsManagerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("windowSize")] 
		public Vector2 WindowSize
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(24)] 
		[RED("previousMenuElement")] 
		public CEnum<RadialHubMenuElement> PreviousMenuElement
		{
			get => GetPropertyValue<CEnum<RadialHubMenuElement>>();
			set => SetPropertyValue<CEnum<RadialHubMenuElement>>(value);
		}

		[Ordinal(25)] 
		[RED("hoveredButtons")] 
		public CArray<CInt32> HoveredButtons
		{
			get => GetPropertyValue<CArray<CInt32>>();
			set => SetPropertyValue<CArray<CInt32>>(value);
		}

		[Ordinal(26)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(27)] 
		[RED("timeSkipOpened")] 
		public CBool TimeSkipOpened
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(28)] 
		[RED("panelHoverOverAnimProxy")] 
		public CHandle<inkanimProxy> PanelHoverOverAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(29)] 
		[RED("panelHoverOutAnimProxy")] 
		public CHandle<inkanimProxy> PanelHoverOutAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public RadialMenuHubLogicController()
		{
			MenuObject = new inkWidgetReference();
			BtnCrafting = new inkWidgetReference();
			BtnPerks = new inkWidgetReference();
			BtnStats = new inkWidgetReference();
			BtnInventory = new inkWidgetReference();
			BtnBackpack = new inkWidgetReference();
			BtnCyberware = new inkWidgetReference();
			BtnMap = new inkWidgetReference();
			BtnJournal = new inkWidgetReference();
			BtnPhone = new inkWidgetReference();
			BtnTarot = new inkWidgetReference();
			BtnShard = new inkWidgetReference();
			BtnCodex = new inkWidgetReference();
			PanelInventory = new inkWidgetReference();
			PanelMap = new inkWidgetReference();
			PanelJournal = new inkWidgetReference();
			PanelCharacter = new inkWidgetReference();
			MouseCollider = new inkWidgetReference();
			DebugText = new inkTextWidgetReference();
			TooltipsManagerRef = new inkWidgetReference();
			WindowSize = new Vector2();
			HoveredButtons = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
