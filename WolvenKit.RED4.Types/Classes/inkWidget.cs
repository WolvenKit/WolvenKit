using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkWidget : IScriptable
	{
		private CHandle<inkWidgetLogicController> _logicController;
		private CArray<CHandle<inkWidgetLogicController>> _secondaryControllers;
		private CArray<CHandle<inkUserData>> _userData;
		private CName _name;
		private CName _state;
		private CBool _visible;
		private CBool _affectsLayoutWhenHidden;
		private CBool _isInteractive;
		private CBool _canSupportFocus;
		private CHandle<inkStyleResourceWrapper> _style;
		private CWeakHandle<inkWidget> _parentWidget;
		private CHandle<inkPropertyManager> _propertyManager;
		private CBool _fitToContent;
		private inkWidgetLayout _layout;
		private CFloat _opacity;
		private HDRColor _tintColor;
		private Vector2 _size;
		private Vector2 _renderTransformPivot;
		private inkUITransform _renderTransform;
		private CArray<CHandle<inkIEffect>> _effects;

		[Ordinal(0)] 
		[RED("logicController")] 
		public CHandle<inkWidgetLogicController> LogicController
		{
			get => GetProperty(ref _logicController);
			set => SetProperty(ref _logicController, value);
		}

		[Ordinal(1)] 
		[RED("secondaryControllers")] 
		public CArray<CHandle<inkWidgetLogicController>> SecondaryControllers
		{
			get => GetProperty(ref _secondaryControllers);
			set => SetProperty(ref _secondaryControllers, value);
		}

		[Ordinal(2)] 
		[RED("userData")] 
		public CArray<CHandle<inkUserData>> UserData
		{
			get => GetProperty(ref _userData);
			set => SetProperty(ref _userData, value);
		}

		[Ordinal(3)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(4)] 
		[RED("state")] 
		public CName State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		[Ordinal(5)] 
		[RED("visible")] 
		public CBool Visible
		{
			get => GetProperty(ref _visible);
			set => SetProperty(ref _visible, value);
		}

		[Ordinal(6)] 
		[RED("affectsLayoutWhenHidden")] 
		public CBool AffectsLayoutWhenHidden
		{
			get => GetProperty(ref _affectsLayoutWhenHidden);
			set => SetProperty(ref _affectsLayoutWhenHidden, value);
		}

		[Ordinal(7)] 
		[RED("isInteractive")] 
		public CBool IsInteractive
		{
			get => GetProperty(ref _isInteractive);
			set => SetProperty(ref _isInteractive, value);
		}

		[Ordinal(8)] 
		[RED("canSupportFocus")] 
		public CBool CanSupportFocus
		{
			get => GetProperty(ref _canSupportFocus);
			set => SetProperty(ref _canSupportFocus, value);
		}

		[Ordinal(9)] 
		[RED("style")] 
		public CHandle<inkStyleResourceWrapper> Style
		{
			get => GetProperty(ref _style);
			set => SetProperty(ref _style, value);
		}

		[Ordinal(10)] 
		[RED("parentWidget")] 
		public CWeakHandle<inkWidget> ParentWidget
		{
			get => GetProperty(ref _parentWidget);
			set => SetProperty(ref _parentWidget, value);
		}

		[Ordinal(11)] 
		[RED("propertyManager")] 
		public CHandle<inkPropertyManager> PropertyManager
		{
			get => GetProperty(ref _propertyManager);
			set => SetProperty(ref _propertyManager, value);
		}

		[Ordinal(12)] 
		[RED("fitToContent")] 
		public CBool FitToContent
		{
			get => GetProperty(ref _fitToContent);
			set => SetProperty(ref _fitToContent, value);
		}

		[Ordinal(13)] 
		[RED("layout")] 
		public inkWidgetLayout Layout
		{
			get => GetProperty(ref _layout);
			set => SetProperty(ref _layout, value);
		}

		[Ordinal(14)] 
		[RED("opacity")] 
		public CFloat Opacity
		{
			get => GetProperty(ref _opacity);
			set => SetProperty(ref _opacity, value);
		}

		[Ordinal(15)] 
		[RED("tintColor")] 
		public HDRColor TintColor
		{
			get => GetProperty(ref _tintColor);
			set => SetProperty(ref _tintColor, value);
		}

		[Ordinal(16)] 
		[RED("size")] 
		public Vector2 Size
		{
			get => GetProperty(ref _size);
			set => SetProperty(ref _size, value);
		}

		[Ordinal(17)] 
		[RED("renderTransformPivot")] 
		public Vector2 RenderTransformPivot
		{
			get => GetProperty(ref _renderTransformPivot);
			set => SetProperty(ref _renderTransformPivot, value);
		}

		[Ordinal(18)] 
		[RED("renderTransform")] 
		public inkUITransform RenderTransform
		{
			get => GetProperty(ref _renderTransform);
			set => SetProperty(ref _renderTransform, value);
		}

		[Ordinal(19)] 
		[RED("effects")] 
		public CArray<CHandle<inkIEffect>> Effects
		{
			get => GetProperty(ref _effects);
			set => SetProperty(ref _effects, value);
		}

		public inkWidget()
		{
			_name = "UNINITIALIZED_WIDGET";
			_state = "Default";
			_visible = true;
			_opacity = 1.000000F;
		}
	}
}
