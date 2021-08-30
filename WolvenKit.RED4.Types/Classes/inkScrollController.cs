using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkScrollController : inkWidgetLogicController
	{
		private inkScrollAreaWidgetReference _scrollArea;
		private inkWidgetReference _verticalScrollBarRef;
		private inkWidgetReference _navigableCompoundWidget;
		private inkCompoundWidgetReference _compoundWidgetRef;
		private CBool _autoHideVertical;
		private CFloat _scrollSpeedGamepad;
		private CFloat _scrollSpeedMouse;
		private CEnum<inkEScrollDirection> _direction;
		private CBool _useGlobalInput;
		private CFloat _position;
		private CFloat _scrollDelta;
		private Vector2 _viewportSize;
		private Vector2 _contentSize;

		[Ordinal(1)] 
		[RED("ScrollArea")] 
		public inkScrollAreaWidgetReference ScrollArea
		{
			get => GetProperty(ref _scrollArea);
			set => SetProperty(ref _scrollArea, value);
		}

		[Ordinal(2)] 
		[RED("VerticalScrollBarRef")] 
		public inkWidgetReference VerticalScrollBarRef
		{
			get => GetProperty(ref _verticalScrollBarRef);
			set => SetProperty(ref _verticalScrollBarRef, value);
		}

		[Ordinal(3)] 
		[RED("navigableCompoundWidget")] 
		public inkWidgetReference NavigableCompoundWidget
		{
			get => GetProperty(ref _navigableCompoundWidget);
			set => SetProperty(ref _navigableCompoundWidget, value);
		}

		[Ordinal(4)] 
		[RED("CompoundWidgetRef")] 
		public inkCompoundWidgetReference CompoundWidgetRef
		{
			get => GetProperty(ref _compoundWidgetRef);
			set => SetProperty(ref _compoundWidgetRef, value);
		}

		[Ordinal(5)] 
		[RED("autoHideVertical")] 
		public CBool AutoHideVertical
		{
			get => GetProperty(ref _autoHideVertical);
			set => SetProperty(ref _autoHideVertical, value);
		}

		[Ordinal(6)] 
		[RED("scrollSpeedGamepad")] 
		public CFloat ScrollSpeedGamepad
		{
			get => GetProperty(ref _scrollSpeedGamepad);
			set => SetProperty(ref _scrollSpeedGamepad, value);
		}

		[Ordinal(7)] 
		[RED("scrollSpeedMouse")] 
		public CFloat ScrollSpeedMouse
		{
			get => GetProperty(ref _scrollSpeedMouse);
			set => SetProperty(ref _scrollSpeedMouse, value);
		}

		[Ordinal(8)] 
		[RED("direction")] 
		public CEnum<inkEScrollDirection> Direction
		{
			get => GetProperty(ref _direction);
			set => SetProperty(ref _direction, value);
		}

		[Ordinal(9)] 
		[RED("useGlobalInput")] 
		public CBool UseGlobalInput
		{
			get => GetProperty(ref _useGlobalInput);
			set => SetProperty(ref _useGlobalInput, value);
		}

		[Ordinal(10)] 
		[RED("position")] 
		public CFloat Position
		{
			get => GetProperty(ref _position);
			set => SetProperty(ref _position, value);
		}

		[Ordinal(11)] 
		[RED("scrollDelta")] 
		public CFloat ScrollDelta
		{
			get => GetProperty(ref _scrollDelta);
			set => SetProperty(ref _scrollDelta, value);
		}

		[Ordinal(12)] 
		[RED("viewportSize")] 
		public Vector2 ViewportSize
		{
			get => GetProperty(ref _viewportSize);
			set => SetProperty(ref _viewportSize, value);
		}

		[Ordinal(13)] 
		[RED("contentSize")] 
		public Vector2 ContentSize
		{
			get => GetProperty(ref _contentSize);
			set => SetProperty(ref _contentSize, value);
		}

		public inkScrollController()
		{
			_autoHideVertical = true;
			_scrollSpeedGamepad = 75.000000F;
			_scrollSpeedMouse = 75.000000F;
		}
	}
}
