using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkInputDisplayController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("iconRef")] 
		public inkWidgetReference IconRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("nameRef")] 
		public inkWidgetReference NameRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("canvasRef")] 
		public inkWidgetReference CanvasRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("holdIndicatorContainerRef")] 
		public inkCompoundWidgetReference HoldIndicatorContainerRef
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("gamepadHoldIndicatorLibraryRef")] 
		public inkWidgetLibraryReference GamepadHoldIndicatorLibraryRef
		{
			get => GetPropertyValue<inkWidgetLibraryReference>();
			set => SetPropertyValue<inkWidgetLibraryReference>(value);
		}

		[Ordinal(6)] 
		[RED("keyboardHoldIndicatorLibraryRef")] 
		public inkWidgetLibraryReference KeyboardHoldIndicatorLibraryRef
		{
			get => GetPropertyValue<inkWidgetLibraryReference>();
			set => SetPropertyValue<inkWidgetLibraryReference>(value);
		}

		[Ordinal(7)] 
		[RED("supportAnimatedHoldIndicator")] 
		public CBool SupportAnimatedHoldIndicator
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("holdIndicationType")] 
		public CEnum<inkInputHintHoldIndicationType> HoldIndicationType
		{
			get => GetPropertyValue<CEnum<inkInputHintHoldIndicationType>>();
			set => SetPropertyValue<CEnum<inkInputHintHoldIndicationType>>(value);
		}

		[Ordinal(9)] 
		[RED("inputActionName")] 
		public CName InputActionName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(10)] 
		[RED("fixedIconHeight")] 
		public CFloat FixedIconHeight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public inkInputDisplayController()
		{
			IconRef = new();
			NameRef = new();
			CanvasRef = new();
			HoldIndicatorContainerRef = new();
			GamepadHoldIndicatorLibraryRef = new() { WidgetLibrary = new() };
			KeyboardHoldIndicatorLibraryRef = new() { WidgetLibrary = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
