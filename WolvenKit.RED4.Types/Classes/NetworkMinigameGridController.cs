using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NetworkMinigameGridController : inkWidgetLogicController
	{
		private inkWidgetReference _gridContainer;
		private inkWidgetReference _horizontalHoverHighlight;
		private inkWidgetReference _horizontalCurrentHighlight;
		private inkWidgetReference _verticalHoverHighlight;
		private inkWidgetReference _verticalCurrentHighlight;
		private Vector2 _gridVisualOffset;
		private CName _gridCellLibraryName;
		private CArray<CellData> _gridData;
		private CellData _lastSelected;
		private Vector2 _currentActivePosition;
		private CBool _isHorizontalHighlight;
		private CellData _lastHighlighted;
		private CHandle<inkanimProxy> _animProxy;
		private CHandle<inkanimProxy> _animHighlightProxy;
		private CBool _firstBoot;
		private CBool _isHorizontal;

		[Ordinal(1)] 
		[RED("gridContainer")] 
		public inkWidgetReference GridContainer
		{
			get => GetProperty(ref _gridContainer);
			set => SetProperty(ref _gridContainer, value);
		}

		[Ordinal(2)] 
		[RED("horizontalHoverHighlight")] 
		public inkWidgetReference HorizontalHoverHighlight
		{
			get => GetProperty(ref _horizontalHoverHighlight);
			set => SetProperty(ref _horizontalHoverHighlight, value);
		}

		[Ordinal(3)] 
		[RED("horizontalCurrentHighlight")] 
		public inkWidgetReference HorizontalCurrentHighlight
		{
			get => GetProperty(ref _horizontalCurrentHighlight);
			set => SetProperty(ref _horizontalCurrentHighlight, value);
		}

		[Ordinal(4)] 
		[RED("verticalHoverHighlight")] 
		public inkWidgetReference VerticalHoverHighlight
		{
			get => GetProperty(ref _verticalHoverHighlight);
			set => SetProperty(ref _verticalHoverHighlight, value);
		}

		[Ordinal(5)] 
		[RED("verticalCurrentHighlight")] 
		public inkWidgetReference VerticalCurrentHighlight
		{
			get => GetProperty(ref _verticalCurrentHighlight);
			set => SetProperty(ref _verticalCurrentHighlight, value);
		}

		[Ordinal(6)] 
		[RED("gridVisualOffset")] 
		public Vector2 GridVisualOffset
		{
			get => GetProperty(ref _gridVisualOffset);
			set => SetProperty(ref _gridVisualOffset, value);
		}

		[Ordinal(7)] 
		[RED("gridCellLibraryName")] 
		public CName GridCellLibraryName
		{
			get => GetProperty(ref _gridCellLibraryName);
			set => SetProperty(ref _gridCellLibraryName, value);
		}

		[Ordinal(8)] 
		[RED("gridData")] 
		public CArray<CellData> GridData
		{
			get => GetProperty(ref _gridData);
			set => SetProperty(ref _gridData, value);
		}

		[Ordinal(9)] 
		[RED("lastSelected")] 
		public CellData LastSelected
		{
			get => GetProperty(ref _lastSelected);
			set => SetProperty(ref _lastSelected, value);
		}

		[Ordinal(10)] 
		[RED("currentActivePosition")] 
		public Vector2 CurrentActivePosition
		{
			get => GetProperty(ref _currentActivePosition);
			set => SetProperty(ref _currentActivePosition, value);
		}

		[Ordinal(11)] 
		[RED("isHorizontalHighlight")] 
		public CBool IsHorizontalHighlight
		{
			get => GetProperty(ref _isHorizontalHighlight);
			set => SetProperty(ref _isHorizontalHighlight, value);
		}

		[Ordinal(12)] 
		[RED("lastHighlighted")] 
		public CellData LastHighlighted
		{
			get => GetProperty(ref _lastHighlighted);
			set => SetProperty(ref _lastHighlighted, value);
		}

		[Ordinal(13)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetProperty(ref _animProxy);
			set => SetProperty(ref _animProxy, value);
		}

		[Ordinal(14)] 
		[RED("animHighlightProxy")] 
		public CHandle<inkanimProxy> AnimHighlightProxy
		{
			get => GetProperty(ref _animHighlightProxy);
			set => SetProperty(ref _animHighlightProxy, value);
		}

		[Ordinal(15)] 
		[RED("firstBoot")] 
		public CBool FirstBoot
		{
			get => GetProperty(ref _firstBoot);
			set => SetProperty(ref _firstBoot, value);
		}

		[Ordinal(16)] 
		[RED("isHorizontal")] 
		public CBool IsHorizontal
		{
			get => GetProperty(ref _isHorizontal);
			set => SetProperty(ref _isHorizontal, value);
		}
	}
}
