using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ProgressBarSimpleWidgetLogicController : inkWidgetLogicController
	{
		private CFloat _width;
		private CFloat _height;
		private CFloat _currentValue;
		private CFloat _previousValue;
		private CFloat _maxCNBarFlashSize;
		private inkWidgetReference _fullBar;
		private inkWidgetReference _changePBar;
		private inkWidgetReference _changeNBar;
		private inkWidgetReference _emptyBar;
		private inkWidgetReference _barCap;
		private CBool _showBarCap;
		private CFloat _animDuration;
		private CHandle<inkanimProxy> _full_anim_proxy;
		private CHandle<inkanimDefinition> _full_anim;
		private CHandle<inkanimProxy> _empty_anim_proxy;
		private CHandle<inkanimDefinition> _empty_anim;
		private CHandle<inkanimProxy> _changeP_anim_proxy;
		private CHandle<inkanimDefinition> _changeP_anim;
		private CHandle<inkanimProxy> _changeN_anim_proxy;
		private CHandle<inkanimDefinition> _changeN_anim;
		private CHandle<inkanimProxy> _barCap_anim_proxy;
		private CHandle<inkanimDefinition> _barCap_anim;
		private wCHandle<inkCompoundWidget> _rootWidget;

		[Ordinal(1)] 
		[RED("width")] 
		public CFloat Width
		{
			get
			{
				if (_width == null)
				{
					_width = (CFloat) CR2WTypeManager.Create("Float", "width", cr2w, this);
				}
				return _width;
			}
			set
			{
				if (_width == value)
				{
					return;
				}
				_width = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("height")] 
		public CFloat Height
		{
			get
			{
				if (_height == null)
				{
					_height = (CFloat) CR2WTypeManager.Create("Float", "height", cr2w, this);
				}
				return _height;
			}
			set
			{
				if (_height == value)
				{
					return;
				}
				_height = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("currentValue")] 
		public CFloat CurrentValue
		{
			get
			{
				if (_currentValue == null)
				{
					_currentValue = (CFloat) CR2WTypeManager.Create("Float", "currentValue", cr2w, this);
				}
				return _currentValue;
			}
			set
			{
				if (_currentValue == value)
				{
					return;
				}
				_currentValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("previousValue")] 
		public CFloat PreviousValue
		{
			get
			{
				if (_previousValue == null)
				{
					_previousValue = (CFloat) CR2WTypeManager.Create("Float", "previousValue", cr2w, this);
				}
				return _previousValue;
			}
			set
			{
				if (_previousValue == value)
				{
					return;
				}
				_previousValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("MaxCNBarFlashSize")] 
		public CFloat MaxCNBarFlashSize
		{
			get
			{
				if (_maxCNBarFlashSize == null)
				{
					_maxCNBarFlashSize = (CFloat) CR2WTypeManager.Create("Float", "MaxCNBarFlashSize", cr2w, this);
				}
				return _maxCNBarFlashSize;
			}
			set
			{
				if (_maxCNBarFlashSize == value)
				{
					return;
				}
				_maxCNBarFlashSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("fullBar")] 
		public inkWidgetReference FullBar
		{
			get
			{
				if (_fullBar == null)
				{
					_fullBar = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "fullBar", cr2w, this);
				}
				return _fullBar;
			}
			set
			{
				if (_fullBar == value)
				{
					return;
				}
				_fullBar = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("changePBar")] 
		public inkWidgetReference ChangePBar
		{
			get
			{
				if (_changePBar == null)
				{
					_changePBar = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "changePBar", cr2w, this);
				}
				return _changePBar;
			}
			set
			{
				if (_changePBar == value)
				{
					return;
				}
				_changePBar = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("changeNBar")] 
		public inkWidgetReference ChangeNBar
		{
			get
			{
				if (_changeNBar == null)
				{
					_changeNBar = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "changeNBar", cr2w, this);
				}
				return _changeNBar;
			}
			set
			{
				if (_changeNBar == value)
				{
					return;
				}
				_changeNBar = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("emptyBar")] 
		public inkWidgetReference EmptyBar
		{
			get
			{
				if (_emptyBar == null)
				{
					_emptyBar = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "emptyBar", cr2w, this);
				}
				return _emptyBar;
			}
			set
			{
				if (_emptyBar == value)
				{
					return;
				}
				_emptyBar = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("barCap")] 
		public inkWidgetReference BarCap
		{
			get
			{
				if (_barCap == null)
				{
					_barCap = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "barCap", cr2w, this);
				}
				return _barCap;
			}
			set
			{
				if (_barCap == value)
				{
					return;
				}
				_barCap = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("showBarCap")] 
		public CBool ShowBarCap
		{
			get
			{
				if (_showBarCap == null)
				{
					_showBarCap = (CBool) CR2WTypeManager.Create("Bool", "showBarCap", cr2w, this);
				}
				return _showBarCap;
			}
			set
			{
				if (_showBarCap == value)
				{
					return;
				}
				_showBarCap = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("animDuration")] 
		public CFloat AnimDuration
		{
			get
			{
				if (_animDuration == null)
				{
					_animDuration = (CFloat) CR2WTypeManager.Create("Float", "animDuration", cr2w, this);
				}
				return _animDuration;
			}
			set
			{
				if (_animDuration == value)
				{
					return;
				}
				_animDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("full_anim_proxy")] 
		public CHandle<inkanimProxy> Full_anim_proxy
		{
			get
			{
				if (_full_anim_proxy == null)
				{
					_full_anim_proxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "full_anim_proxy", cr2w, this);
				}
				return _full_anim_proxy;
			}
			set
			{
				if (_full_anim_proxy == value)
				{
					return;
				}
				_full_anim_proxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("full_anim")] 
		public CHandle<inkanimDefinition> Full_anim
		{
			get
			{
				if (_full_anim == null)
				{
					_full_anim = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "full_anim", cr2w, this);
				}
				return _full_anim;
			}
			set
			{
				if (_full_anim == value)
				{
					return;
				}
				_full_anim = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("empty_anim_proxy")] 
		public CHandle<inkanimProxy> Empty_anim_proxy
		{
			get
			{
				if (_empty_anim_proxy == null)
				{
					_empty_anim_proxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "empty_anim_proxy", cr2w, this);
				}
				return _empty_anim_proxy;
			}
			set
			{
				if (_empty_anim_proxy == value)
				{
					return;
				}
				_empty_anim_proxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("empty_anim")] 
		public CHandle<inkanimDefinition> Empty_anim
		{
			get
			{
				if (_empty_anim == null)
				{
					_empty_anim = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "empty_anim", cr2w, this);
				}
				return _empty_anim;
			}
			set
			{
				if (_empty_anim == value)
				{
					return;
				}
				_empty_anim = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("changeP_anim_proxy")] 
		public CHandle<inkanimProxy> ChangeP_anim_proxy
		{
			get
			{
				if (_changeP_anim_proxy == null)
				{
					_changeP_anim_proxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "changeP_anim_proxy", cr2w, this);
				}
				return _changeP_anim_proxy;
			}
			set
			{
				if (_changeP_anim_proxy == value)
				{
					return;
				}
				_changeP_anim_proxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("changeP_anim")] 
		public CHandle<inkanimDefinition> ChangeP_anim
		{
			get
			{
				if (_changeP_anim == null)
				{
					_changeP_anim = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "changeP_anim", cr2w, this);
				}
				return _changeP_anim;
			}
			set
			{
				if (_changeP_anim == value)
				{
					return;
				}
				_changeP_anim = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("changeN_anim_proxy")] 
		public CHandle<inkanimProxy> ChangeN_anim_proxy
		{
			get
			{
				if (_changeN_anim_proxy == null)
				{
					_changeN_anim_proxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "changeN_anim_proxy", cr2w, this);
				}
				return _changeN_anim_proxy;
			}
			set
			{
				if (_changeN_anim_proxy == value)
				{
					return;
				}
				_changeN_anim_proxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("changeN_anim")] 
		public CHandle<inkanimDefinition> ChangeN_anim
		{
			get
			{
				if (_changeN_anim == null)
				{
					_changeN_anim = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "changeN_anim", cr2w, this);
				}
				return _changeN_anim;
			}
			set
			{
				if (_changeN_anim == value)
				{
					return;
				}
				_changeN_anim = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("barCap_anim_proxy")] 
		public CHandle<inkanimProxy> BarCap_anim_proxy
		{
			get
			{
				if (_barCap_anim_proxy == null)
				{
					_barCap_anim_proxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "barCap_anim_proxy", cr2w, this);
				}
				return _barCap_anim_proxy;
			}
			set
			{
				if (_barCap_anim_proxy == value)
				{
					return;
				}
				_barCap_anim_proxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("barCap_anim")] 
		public CHandle<inkanimDefinition> BarCap_anim
		{
			get
			{
				if (_barCap_anim == null)
				{
					_barCap_anim = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "barCap_anim", cr2w, this);
				}
				return _barCap_anim;
			}
			set
			{
				if (_barCap_anim == value)
				{
					return;
				}
				_barCap_anim = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("rootWidget")] 
		public wCHandle<inkCompoundWidget> RootWidget
		{
			get
			{
				if (_rootWidget == null)
				{
					_rootWidget = (wCHandle<inkCompoundWidget>) CR2WTypeManager.Create("whandle:inkCompoundWidget", "rootWidget", cr2w, this);
				}
				return _rootWidget;
			}
			set
			{
				if (_rootWidget == value)
				{
					return;
				}
				_rootWidget = value;
				PropertySet(this);
			}
		}

		public ProgressBarSimpleWidgetLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
