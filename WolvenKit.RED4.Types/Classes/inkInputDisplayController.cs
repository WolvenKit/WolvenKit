using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkInputDisplayController : inkWidgetLogicController
	{
		private inkWidgetReference _iconRef;
		private inkWidgetReference _nameRef;
		private inkWidgetReference _canvasRef;
		private inkCompoundWidgetReference _holdIndicatorContainerRef;
		private inkWidgetLibraryReference _gamepadHoldIndicatorLibraryRef;
		private inkWidgetLibraryReference _keyboardHoldIndicatorLibraryRef;
		private CBool _supportAnimatedHoldIndicator;
		private CEnum<inkInputHintHoldIndicationType> _holdIndicationType;
		private CName _inputActionName;
		private CFloat _fixedIconHeight;

		[Ordinal(1)] 
		[RED("iconRef")] 
		public inkWidgetReference IconRef
		{
			get => GetProperty(ref _iconRef);
			set => SetProperty(ref _iconRef, value);
		}

		[Ordinal(2)] 
		[RED("nameRef")] 
		public inkWidgetReference NameRef
		{
			get => GetProperty(ref _nameRef);
			set => SetProperty(ref _nameRef, value);
		}

		[Ordinal(3)] 
		[RED("canvasRef")] 
		public inkWidgetReference CanvasRef
		{
			get => GetProperty(ref _canvasRef);
			set => SetProperty(ref _canvasRef, value);
		}

		[Ordinal(4)] 
		[RED("holdIndicatorContainerRef")] 
		public inkCompoundWidgetReference HoldIndicatorContainerRef
		{
			get => GetProperty(ref _holdIndicatorContainerRef);
			set => SetProperty(ref _holdIndicatorContainerRef, value);
		}

		[Ordinal(5)] 
		[RED("gamepadHoldIndicatorLibraryRef")] 
		public inkWidgetLibraryReference GamepadHoldIndicatorLibraryRef
		{
			get => GetProperty(ref _gamepadHoldIndicatorLibraryRef);
			set => SetProperty(ref _gamepadHoldIndicatorLibraryRef, value);
		}

		[Ordinal(6)] 
		[RED("keyboardHoldIndicatorLibraryRef")] 
		public inkWidgetLibraryReference KeyboardHoldIndicatorLibraryRef
		{
			get => GetProperty(ref _keyboardHoldIndicatorLibraryRef);
			set => SetProperty(ref _keyboardHoldIndicatorLibraryRef, value);
		}

		[Ordinal(7)] 
		[RED("supportAnimatedHoldIndicator")] 
		public CBool SupportAnimatedHoldIndicator
		{
			get => GetProperty(ref _supportAnimatedHoldIndicator);
			set => SetProperty(ref _supportAnimatedHoldIndicator, value);
		}

		[Ordinal(8)] 
		[RED("holdIndicationType")] 
		public CEnum<inkInputHintHoldIndicationType> HoldIndicationType
		{
			get => GetProperty(ref _holdIndicationType);
			set => SetProperty(ref _holdIndicationType, value);
		}

		[Ordinal(9)] 
		[RED("inputActionName")] 
		public CName InputActionName
		{
			get => GetProperty(ref _inputActionName);
			set => SetProperty(ref _inputActionName, value);
		}

		[Ordinal(10)] 
		[RED("fixedIconHeight")] 
		public CFloat FixedIconHeight
		{
			get => GetProperty(ref _fixedIconHeight);
			set => SetProperty(ref _fixedIconHeight, value);
		}
	}
}
