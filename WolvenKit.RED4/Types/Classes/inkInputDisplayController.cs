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
		[RED("iconAND")] 
		public inkTextWidgetReference IconAND
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("nameRef")] 
		public inkWidgetReference NameRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("canvasRef")] 
		public inkWidgetReference CanvasRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("holdIndicatorContainerRef")] 
		public inkCompoundWidgetReference HoldIndicatorContainerRef
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("gamepadHoldIndicatorLibraryRef")] 
		public inkWidgetLibraryReference GamepadHoldIndicatorLibraryRef
		{
			get => GetPropertyValue<inkWidgetLibraryReference>();
			set => SetPropertyValue<inkWidgetLibraryReference>(value);
		}

		[Ordinal(7)] 
		[RED("keyboardHoldIndicatorLibraryRef")] 
		public inkWidgetLibraryReference KeyboardHoldIndicatorLibraryRef
		{
			get => GetPropertyValue<inkWidgetLibraryReference>();
			set => SetPropertyValue<inkWidgetLibraryReference>(value);
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
			IconRef = new inkWidgetReference();
			IconAND = new inkTextWidgetReference();
			NameRef = new inkWidgetReference();
			CanvasRef = new inkWidgetReference();
			HoldIndicatorContainerRef = new inkCompoundWidgetReference();
			GamepadHoldIndicatorLibraryRef = new inkWidgetLibraryReference { WidgetLibrary = new inkWidgetLibraryResourceWrapper() };
			KeyboardHoldIndicatorLibraryRef = new inkWidgetLibraryReference { WidgetLibrary = new inkWidgetLibraryResourceWrapper() };
			HoldIndicationType = Enums.inkInputHintHoldIndicationType.Press;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
