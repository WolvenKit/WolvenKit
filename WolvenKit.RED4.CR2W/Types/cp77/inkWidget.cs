using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkWidget : IScriptable
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
		private wCHandle<inkWidget> _parentWidget;
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
			get
			{
				if (_logicController == null)
				{
					_logicController = (CHandle<inkWidgetLogicController>) CR2WTypeManager.Create("handle:inkWidgetLogicController", "logicController", cr2w, this);
				}
				return _logicController;
			}
			set
			{
				if (_logicController == value)
				{
					return;
				}
				_logicController = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("secondaryControllers")] 
		public CArray<CHandle<inkWidgetLogicController>> SecondaryControllers
		{
			get
			{
				if (_secondaryControllers == null)
				{
					_secondaryControllers = (CArray<CHandle<inkWidgetLogicController>>) CR2WTypeManager.Create("array:handle:inkWidgetLogicController", "secondaryControllers", cr2w, this);
				}
				return _secondaryControllers;
			}
			set
			{
				if (_secondaryControllers == value)
				{
					return;
				}
				_secondaryControllers = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("userData")] 
		public CArray<CHandle<inkUserData>> UserData
		{
			get
			{
				if (_userData == null)
				{
					_userData = (CArray<CHandle<inkUserData>>) CR2WTypeManager.Create("array:handle:inkUserData", "userData", cr2w, this);
				}
				return _userData;
			}
			set
			{
				if (_userData == value)
				{
					return;
				}
				_userData = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("name")] 
		public CName Name
		{
			get
			{
				if (_name == null)
				{
					_name = (CName) CR2WTypeManager.Create("CName", "name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("state")] 
		public CName State
		{
			get
			{
				if (_state == null)
				{
					_state = (CName) CR2WTypeManager.Create("CName", "state", cr2w, this);
				}
				return _state;
			}
			set
			{
				if (_state == value)
				{
					return;
				}
				_state = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("visible")] 
		public CBool Visible
		{
			get
			{
				if (_visible == null)
				{
					_visible = (CBool) CR2WTypeManager.Create("Bool", "visible", cr2w, this);
				}
				return _visible;
			}
			set
			{
				if (_visible == value)
				{
					return;
				}
				_visible = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("affectsLayoutWhenHidden")] 
		public CBool AffectsLayoutWhenHidden
		{
			get
			{
				if (_affectsLayoutWhenHidden == null)
				{
					_affectsLayoutWhenHidden = (CBool) CR2WTypeManager.Create("Bool", "affectsLayoutWhenHidden", cr2w, this);
				}
				return _affectsLayoutWhenHidden;
			}
			set
			{
				if (_affectsLayoutWhenHidden == value)
				{
					return;
				}
				_affectsLayoutWhenHidden = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("isInteractive")] 
		public CBool IsInteractive
		{
			get
			{
				if (_isInteractive == null)
				{
					_isInteractive = (CBool) CR2WTypeManager.Create("Bool", "isInteractive", cr2w, this);
				}
				return _isInteractive;
			}
			set
			{
				if (_isInteractive == value)
				{
					return;
				}
				_isInteractive = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("canSupportFocus")] 
		public CBool CanSupportFocus
		{
			get
			{
				if (_canSupportFocus == null)
				{
					_canSupportFocus = (CBool) CR2WTypeManager.Create("Bool", "canSupportFocus", cr2w, this);
				}
				return _canSupportFocus;
			}
			set
			{
				if (_canSupportFocus == value)
				{
					return;
				}
				_canSupportFocus = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("style")] 
		public CHandle<inkStyleResourceWrapper> Style
		{
			get
			{
				if (_style == null)
				{
					_style = (CHandle<inkStyleResourceWrapper>) CR2WTypeManager.Create("handle:inkStyleResourceWrapper", "style", cr2w, this);
				}
				return _style;
			}
			set
			{
				if (_style == value)
				{
					return;
				}
				_style = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("parentWidget")] 
		public wCHandle<inkWidget> ParentWidget
		{
			get
			{
				if (_parentWidget == null)
				{
					_parentWidget = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "parentWidget", cr2w, this);
				}
				return _parentWidget;
			}
			set
			{
				if (_parentWidget == value)
				{
					return;
				}
				_parentWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("propertyManager")] 
		public CHandle<inkPropertyManager> PropertyManager
		{
			get
			{
				if (_propertyManager == null)
				{
					_propertyManager = (CHandle<inkPropertyManager>) CR2WTypeManager.Create("handle:inkPropertyManager", "propertyManager", cr2w, this);
				}
				return _propertyManager;
			}
			set
			{
				if (_propertyManager == value)
				{
					return;
				}
				_propertyManager = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("fitToContent")] 
		public CBool FitToContent
		{
			get
			{
				if (_fitToContent == null)
				{
					_fitToContent = (CBool) CR2WTypeManager.Create("Bool", "fitToContent", cr2w, this);
				}
				return _fitToContent;
			}
			set
			{
				if (_fitToContent == value)
				{
					return;
				}
				_fitToContent = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("layout")] 
		public inkWidgetLayout Layout
		{
			get
			{
				if (_layout == null)
				{
					_layout = (inkWidgetLayout) CR2WTypeManager.Create("inkWidgetLayout", "layout", cr2w, this);
				}
				return _layout;
			}
			set
			{
				if (_layout == value)
				{
					return;
				}
				_layout = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("opacity")] 
		public CFloat Opacity
		{
			get
			{
				if (_opacity == null)
				{
					_opacity = (CFloat) CR2WTypeManager.Create("Float", "opacity", cr2w, this);
				}
				return _opacity;
			}
			set
			{
				if (_opacity == value)
				{
					return;
				}
				_opacity = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("tintColor")] 
		public HDRColor TintColor
		{
			get
			{
				if (_tintColor == null)
				{
					_tintColor = (HDRColor) CR2WTypeManager.Create("HDRColor", "tintColor", cr2w, this);
				}
				return _tintColor;
			}
			set
			{
				if (_tintColor == value)
				{
					return;
				}
				_tintColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("size")] 
		public Vector2 Size
		{
			get
			{
				if (_size == null)
				{
					_size = (Vector2) CR2WTypeManager.Create("Vector2", "size", cr2w, this);
				}
				return _size;
			}
			set
			{
				if (_size == value)
				{
					return;
				}
				_size = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("renderTransformPivot")] 
		public Vector2 RenderTransformPivot
		{
			get
			{
				if (_renderTransformPivot == null)
				{
					_renderTransformPivot = (Vector2) CR2WTypeManager.Create("Vector2", "renderTransformPivot", cr2w, this);
				}
				return _renderTransformPivot;
			}
			set
			{
				if (_renderTransformPivot == value)
				{
					return;
				}
				_renderTransformPivot = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("renderTransform")] 
		public inkUITransform RenderTransform
		{
			get
			{
				if (_renderTransform == null)
				{
					_renderTransform = (inkUITransform) CR2WTypeManager.Create("inkUITransform", "renderTransform", cr2w, this);
				}
				return _renderTransform;
			}
			set
			{
				if (_renderTransform == value)
				{
					return;
				}
				_renderTransform = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("effects")] 
		public CArray<CHandle<inkIEffect>> Effects
		{
			get
			{
				if (_effects == null)
				{
					_effects = (CArray<CHandle<inkIEffect>>) CR2WTypeManager.Create("array:handle:inkIEffect", "effects", cr2w, this);
				}
				return _effects;
			}
			set
			{
				if (_effects == value)
				{
					return;
				}
				_effects = value;
				PropertySet(this);
			}
		}

		public inkWidget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
