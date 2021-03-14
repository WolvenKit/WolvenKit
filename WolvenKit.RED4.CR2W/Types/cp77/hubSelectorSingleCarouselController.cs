using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class hubSelectorSingleCarouselController : inkSelectorController
	{
		private CInt32 _nUMBER_OF_WIDGETS;
		private CFloat _wIDGETS_PADDING;
		private CFloat _sMALL_WIDGET_SCALE;
		private CFloat _sMALL_WIDGET_OPACITY;
		private CFloat _aNIMATION_TIME;
		private HDRColor _dEFAULT_WIDGET_COLOR;
		private HDRColor _sELECTED_WIDGET_COLOR;
		private inkWidgetReference _leftArrowWidget;
		private inkWidgetReference _rightArrowWidget;
		private inkWidgetReference _container;
		private inkWidgetReference _defaultColorDummy;
		private inkWidgetReference _activeColorDummy;
		private CHandle<inkInputDisplayController> _leftArrowController;
		private CHandle<inkInputDisplayController> _rightArrowController;
		private CArray<MenuData> _elements;
		private CInt32 _centerElementIndex;
		private CArray<CHandle<HubMenuLabelContentContainer>> _widgetsControllers;
		private CBool _waitForSizes;
		private CBool _translationOnce;
		private CInt32 _currentIndex;
		private CArray<CHandle<inkanimProxy>> _activeAnimations;

		[Ordinal(15)] 
		[RED("NUMBER_OF_WIDGETS")] 
		public CInt32 NUMBER_OF_WIDGETS
		{
			get
			{
				if (_nUMBER_OF_WIDGETS == null)
				{
					_nUMBER_OF_WIDGETS = (CInt32) CR2WTypeManager.Create("Int32", "NUMBER_OF_WIDGETS", cr2w, this);
				}
				return _nUMBER_OF_WIDGETS;
			}
			set
			{
				if (_nUMBER_OF_WIDGETS == value)
				{
					return;
				}
				_nUMBER_OF_WIDGETS = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("WIDGETS_PADDING")] 
		public CFloat WIDGETS_PADDING
		{
			get
			{
				if (_wIDGETS_PADDING == null)
				{
					_wIDGETS_PADDING = (CFloat) CR2WTypeManager.Create("Float", "WIDGETS_PADDING", cr2w, this);
				}
				return _wIDGETS_PADDING;
			}
			set
			{
				if (_wIDGETS_PADDING == value)
				{
					return;
				}
				_wIDGETS_PADDING = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("SMALL_WIDGET_SCALE")] 
		public CFloat SMALL_WIDGET_SCALE
		{
			get
			{
				if (_sMALL_WIDGET_SCALE == null)
				{
					_sMALL_WIDGET_SCALE = (CFloat) CR2WTypeManager.Create("Float", "SMALL_WIDGET_SCALE", cr2w, this);
				}
				return _sMALL_WIDGET_SCALE;
			}
			set
			{
				if (_sMALL_WIDGET_SCALE == value)
				{
					return;
				}
				_sMALL_WIDGET_SCALE = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("SMALL_WIDGET_OPACITY")] 
		public CFloat SMALL_WIDGET_OPACITY
		{
			get
			{
				if (_sMALL_WIDGET_OPACITY == null)
				{
					_sMALL_WIDGET_OPACITY = (CFloat) CR2WTypeManager.Create("Float", "SMALL_WIDGET_OPACITY", cr2w, this);
				}
				return _sMALL_WIDGET_OPACITY;
			}
			set
			{
				if (_sMALL_WIDGET_OPACITY == value)
				{
					return;
				}
				_sMALL_WIDGET_OPACITY = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("ANIMATION_TIME")] 
		public CFloat ANIMATION_TIME
		{
			get
			{
				if (_aNIMATION_TIME == null)
				{
					_aNIMATION_TIME = (CFloat) CR2WTypeManager.Create("Float", "ANIMATION_TIME", cr2w, this);
				}
				return _aNIMATION_TIME;
			}
			set
			{
				if (_aNIMATION_TIME == value)
				{
					return;
				}
				_aNIMATION_TIME = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("DEFAULT_WIDGET_COLOR")] 
		public HDRColor DEFAULT_WIDGET_COLOR
		{
			get
			{
				if (_dEFAULT_WIDGET_COLOR == null)
				{
					_dEFAULT_WIDGET_COLOR = (HDRColor) CR2WTypeManager.Create("HDRColor", "DEFAULT_WIDGET_COLOR", cr2w, this);
				}
				return _dEFAULT_WIDGET_COLOR;
			}
			set
			{
				if (_dEFAULT_WIDGET_COLOR == value)
				{
					return;
				}
				_dEFAULT_WIDGET_COLOR = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("SELECTED_WIDGET_COLOR")] 
		public HDRColor SELECTED_WIDGET_COLOR
		{
			get
			{
				if (_sELECTED_WIDGET_COLOR == null)
				{
					_sELECTED_WIDGET_COLOR = (HDRColor) CR2WTypeManager.Create("HDRColor", "SELECTED_WIDGET_COLOR", cr2w, this);
				}
				return _sELECTED_WIDGET_COLOR;
			}
			set
			{
				if (_sELECTED_WIDGET_COLOR == value)
				{
					return;
				}
				_sELECTED_WIDGET_COLOR = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("leftArrowWidget")] 
		public inkWidgetReference LeftArrowWidget
		{
			get
			{
				if (_leftArrowWidget == null)
				{
					_leftArrowWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "leftArrowWidget", cr2w, this);
				}
				return _leftArrowWidget;
			}
			set
			{
				if (_leftArrowWidget == value)
				{
					return;
				}
				_leftArrowWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("rightArrowWidget")] 
		public inkWidgetReference RightArrowWidget
		{
			get
			{
				if (_rightArrowWidget == null)
				{
					_rightArrowWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "rightArrowWidget", cr2w, this);
				}
				return _rightArrowWidget;
			}
			set
			{
				if (_rightArrowWidget == value)
				{
					return;
				}
				_rightArrowWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("container")] 
		public inkWidgetReference Container
		{
			get
			{
				if (_container == null)
				{
					_container = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "container", cr2w, this);
				}
				return _container;
			}
			set
			{
				if (_container == value)
				{
					return;
				}
				_container = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("defaultColorDummy")] 
		public inkWidgetReference DefaultColorDummy
		{
			get
			{
				if (_defaultColorDummy == null)
				{
					_defaultColorDummy = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "defaultColorDummy", cr2w, this);
				}
				return _defaultColorDummy;
			}
			set
			{
				if (_defaultColorDummy == value)
				{
					return;
				}
				_defaultColorDummy = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("activeColorDummy")] 
		public inkWidgetReference ActiveColorDummy
		{
			get
			{
				if (_activeColorDummy == null)
				{
					_activeColorDummy = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "activeColorDummy", cr2w, this);
				}
				return _activeColorDummy;
			}
			set
			{
				if (_activeColorDummy == value)
				{
					return;
				}
				_activeColorDummy = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("leftArrowController")] 
		public CHandle<inkInputDisplayController> LeftArrowController
		{
			get
			{
				if (_leftArrowController == null)
				{
					_leftArrowController = (CHandle<inkInputDisplayController>) CR2WTypeManager.Create("handle:inkInputDisplayController", "leftArrowController", cr2w, this);
				}
				return _leftArrowController;
			}
			set
			{
				if (_leftArrowController == value)
				{
					return;
				}
				_leftArrowController = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("rightArrowController")] 
		public CHandle<inkInputDisplayController> RightArrowController
		{
			get
			{
				if (_rightArrowController == null)
				{
					_rightArrowController = (CHandle<inkInputDisplayController>) CR2WTypeManager.Create("handle:inkInputDisplayController", "rightArrowController", cr2w, this);
				}
				return _rightArrowController;
			}
			set
			{
				if (_rightArrowController == value)
				{
					return;
				}
				_rightArrowController = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("elements")] 
		public CArray<MenuData> Elements
		{
			get
			{
				if (_elements == null)
				{
					_elements = (CArray<MenuData>) CR2WTypeManager.Create("array:MenuData", "elements", cr2w, this);
				}
				return _elements;
			}
			set
			{
				if (_elements == value)
				{
					return;
				}
				_elements = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("centerElementIndex")] 
		public CInt32 CenterElementIndex
		{
			get
			{
				if (_centerElementIndex == null)
				{
					_centerElementIndex = (CInt32) CR2WTypeManager.Create("Int32", "centerElementIndex", cr2w, this);
				}
				return _centerElementIndex;
			}
			set
			{
				if (_centerElementIndex == value)
				{
					return;
				}
				_centerElementIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("widgetsControllers")] 
		public CArray<CHandle<HubMenuLabelContentContainer>> WidgetsControllers
		{
			get
			{
				if (_widgetsControllers == null)
				{
					_widgetsControllers = (CArray<CHandle<HubMenuLabelContentContainer>>) CR2WTypeManager.Create("array:handle:HubMenuLabelContentContainer", "widgetsControllers", cr2w, this);
				}
				return _widgetsControllers;
			}
			set
			{
				if (_widgetsControllers == value)
				{
					return;
				}
				_widgetsControllers = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("waitForSizes")] 
		public CBool WaitForSizes
		{
			get
			{
				if (_waitForSizes == null)
				{
					_waitForSizes = (CBool) CR2WTypeManager.Create("Bool", "waitForSizes", cr2w, this);
				}
				return _waitForSizes;
			}
			set
			{
				if (_waitForSizes == value)
				{
					return;
				}
				_waitForSizes = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("translationOnce")] 
		public CBool TranslationOnce
		{
			get
			{
				if (_translationOnce == null)
				{
					_translationOnce = (CBool) CR2WTypeManager.Create("Bool", "translationOnce", cr2w, this);
				}
				return _translationOnce;
			}
			set
			{
				if (_translationOnce == value)
				{
					return;
				}
				_translationOnce = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("currentIndex")] 
		public CInt32 CurrentIndex
		{
			get
			{
				if (_currentIndex == null)
				{
					_currentIndex = (CInt32) CR2WTypeManager.Create("Int32", "currentIndex", cr2w, this);
				}
				return _currentIndex;
			}
			set
			{
				if (_currentIndex == value)
				{
					return;
				}
				_currentIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("activeAnimations")] 
		public CArray<CHandle<inkanimProxy>> ActiveAnimations
		{
			get
			{
				if (_activeAnimations == null)
				{
					_activeAnimations = (CArray<CHandle<inkanimProxy>>) CR2WTypeManager.Create("array:handle:inkanimProxy", "activeAnimations", cr2w, this);
				}
				return _activeAnimations;
			}
			set
			{
				if (_activeAnimations == value)
				{
					return;
				}
				_activeAnimations = value;
				PropertySet(this);
			}
		}

		public hubSelectorSingleCarouselController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
