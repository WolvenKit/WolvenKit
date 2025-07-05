using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkWidget : IScriptable
	{
		[Ordinal(0)] 
		[RED("logicController")] 
		public CHandle<inkWidgetLogicController> LogicController
		{
			get => GetPropertyValue<CHandle<inkWidgetLogicController>>();
			set => SetPropertyValue<CHandle<inkWidgetLogicController>>(value);
		}

		[Ordinal(1)] 
		[RED("secondaryControllers")] 
		public CArray<CHandle<inkWidgetLogicController>> SecondaryControllers
		{
			get => GetPropertyValue<CArray<CHandle<inkWidgetLogicController>>>();
			set => SetPropertyValue<CArray<CHandle<inkWidgetLogicController>>>(value);
		}

		[Ordinal(2)] 
		[RED("userData")] 
		public CArray<CHandle<inkUserData>> UserData
		{
			get => GetPropertyValue<CArray<CHandle<inkUserData>>>();
			set => SetPropertyValue<CArray<CHandle<inkUserData>>>(value);
		}

		[Ordinal(3)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("state")] 
		public CName State
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("visible")] 
		public CBool Visible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("affectsLayoutWhenHidden")] 
		public CBool AffectsLayoutWhenHidden
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("isInteractive")] 
		public CBool IsInteractive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("canSupportFocus")] 
		public CBool CanSupportFocus
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("style")] 
		public CHandle<inkStyleResourceWrapper> Style
		{
			get => GetPropertyValue<CHandle<inkStyleResourceWrapper>>();
			set => SetPropertyValue<CHandle<inkStyleResourceWrapper>>(value);
		}

		[Ordinal(10)] 
		[RED("parentWidget")] 
		public CWeakHandle<inkWidget> ParentWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(11)] 
		[RED("propertyManager")] 
		public CHandle<inkPropertyManager> PropertyManager
		{
			get => GetPropertyValue<CHandle<inkPropertyManager>>();
			set => SetPropertyValue<CHandle<inkPropertyManager>>(value);
		}

		[Ordinal(12)] 
		[RED("fitToContent")] 
		public CBool FitToContent
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("layout")] 
		public inkWidgetLayout Layout
		{
			get => GetPropertyValue<inkWidgetLayout>();
			set => SetPropertyValue<inkWidgetLayout>(value);
		}

		[Ordinal(14)] 
		[RED("opacity")] 
		public CFloat Opacity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(15)] 
		[RED("tintColor")] 
		public HDRColor TintColor
		{
			get => GetPropertyValue<HDRColor>();
			set => SetPropertyValue<HDRColor>(value);
		}

		[Ordinal(16)] 
		[RED("size")] 
		public Vector2 Size
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(17)] 
		[RED("renderTransformPivot")] 
		public Vector2 RenderTransformPivot
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(18)] 
		[RED("renderTransform")] 
		public inkUITransform RenderTransform
		{
			get => GetPropertyValue<inkUITransform>();
			set => SetPropertyValue<inkUITransform>(value);
		}

		[Ordinal(19)] 
		[RED("effects")] 
		public CArray<CHandle<inkIEffect>> Effects
		{
			get => GetPropertyValue<CArray<CHandle<inkIEffect>>>();
			set => SetPropertyValue<CArray<CHandle<inkIEffect>>>(value);
		}

		public inkWidget()
		{
			SecondaryControllers = new();
			UserData = new();
			Name = "UNINITIALIZED_WIDGET";
			State = "Default";
			Visible = true;
			Layout = new inkWidgetLayout { Padding = new inkMargin(), Margin = new inkMargin(), AnchorPoint = new Vector2(), SizeCoefficient = 1.000000F };
			Opacity = 1.000000F;
			TintColor = new HDRColor { Red = 1.000000F, Green = 1.000000F, Blue = 1.000000F, Alpha = 1.000000F };
			Size = new Vector2();
			RenderTransformPivot = new Vector2 { X = 0.500000F, Y = 0.500000F };
			RenderTransform = new inkUITransform { Translation = new Vector2(), Scale = new Vector2 { X = 1.000000F, Y = 1.000000F }, Shear = new Vector2() };
			Effects = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
