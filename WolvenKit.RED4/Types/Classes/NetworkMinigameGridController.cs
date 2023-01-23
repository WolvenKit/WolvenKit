using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NetworkMinigameGridController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("gridContainer")] 
		public inkWidgetReference GridContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("horizontalHoverHighlight")] 
		public inkWidgetReference HorizontalHoverHighlight
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("horizontalCurrentHighlight")] 
		public inkWidgetReference HorizontalCurrentHighlight
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("verticalHoverHighlight")] 
		public inkWidgetReference VerticalHoverHighlight
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("verticalCurrentHighlight")] 
		public inkWidgetReference VerticalCurrentHighlight
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("gridVisualOffset")] 
		public Vector2 GridVisualOffset
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(7)] 
		[RED("gridCellLibraryName")] 
		public CName GridCellLibraryName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("gridData")] 
		public CArray<CellData> GridData
		{
			get => GetPropertyValue<CArray<CellData>>();
			set => SetPropertyValue<CArray<CellData>>(value);
		}

		[Ordinal(9)] 
		[RED("lastSelected")] 
		public CellData LastSelected
		{
			get => GetPropertyValue<CellData>();
			set => SetPropertyValue<CellData>(value);
		}

		[Ordinal(10)] 
		[RED("currentActivePosition")] 
		public Vector2 CurrentActivePosition
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(11)] 
		[RED("isHorizontalHighlight")] 
		public CBool IsHorizontalHighlight
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("lastHighlighted")] 
		public CellData LastHighlighted
		{
			get => GetPropertyValue<CellData>();
			set => SetPropertyValue<CellData>(value);
		}

		[Ordinal(13)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(14)] 
		[RED("animHighlightProxy")] 
		public CHandle<inkanimProxy> AnimHighlightProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(15)] 
		[RED("firstBoot")] 
		public CBool FirstBoot
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(16)] 
		[RED("isHorizontal")] 
		public CBool IsHorizontal
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public NetworkMinigameGridController()
		{
			GridContainer = new();
			HorizontalHoverHighlight = new();
			HorizontalCurrentHighlight = new();
			VerticalHoverHighlight = new();
			VerticalCurrentHighlight = new();
			GridVisualOffset = new();
			GridData = new();
			LastSelected = new() { Position = new(), Element = new(), Properties = new() { Traps = new() } };
			CurrentActivePosition = new();
			LastHighlighted = new() { Position = new(), Element = new(), Properties = new() { Traps = new() } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
