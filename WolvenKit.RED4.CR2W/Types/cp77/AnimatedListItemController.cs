using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimatedListItemController : inkListItemController
	{
		private CName _animOutName;
		private CName _animPulseName;
		private inkWidgetReference _animTargetHover;
		private inkWidgetReference _animTargetPulse;
		private CFloat _normalRootOpacity;
		private CFloat _hoverRootOpacity;
		private wCHandle<inkCompoundWidget> _rootWidget;
		private wCHandle<inkWidget> _animTarget_Hover;
		private wCHandle<inkWidget> _animTarget_Pulse;
		private CHandle<inkanimDefinition> _animHover;
		private CHandle<inkanimDefinition> _animPulse;
		private CHandle<inkanimProxy> _animHoverProxy;
		private CHandle<inkanimProxy> _animPulseProxy;
		private inkanimPlaybackOptions _animPulseOptions;

		[Ordinal(16)] 
		[RED("animOutName")] 
		public CName AnimOutName
		{
			get
			{
				if (_animOutName == null)
				{
					_animOutName = (CName) CR2WTypeManager.Create("CName", "animOutName", cr2w, this);
				}
				return _animOutName;
			}
			set
			{
				if (_animOutName == value)
				{
					return;
				}
				_animOutName = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("animPulseName")] 
		public CName AnimPulseName
		{
			get
			{
				if (_animPulseName == null)
				{
					_animPulseName = (CName) CR2WTypeManager.Create("CName", "animPulseName", cr2w, this);
				}
				return _animPulseName;
			}
			set
			{
				if (_animPulseName == value)
				{
					return;
				}
				_animPulseName = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("animTargetHover")] 
		public inkWidgetReference AnimTargetHover
		{
			get
			{
				if (_animTargetHover == null)
				{
					_animTargetHover = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "animTargetHover", cr2w, this);
				}
				return _animTargetHover;
			}
			set
			{
				if (_animTargetHover == value)
				{
					return;
				}
				_animTargetHover = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("animTargetPulse")] 
		public inkWidgetReference AnimTargetPulse
		{
			get
			{
				if (_animTargetPulse == null)
				{
					_animTargetPulse = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "animTargetPulse", cr2w, this);
				}
				return _animTargetPulse;
			}
			set
			{
				if (_animTargetPulse == value)
				{
					return;
				}
				_animTargetPulse = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("normalRootOpacity")] 
		public CFloat NormalRootOpacity
		{
			get
			{
				if (_normalRootOpacity == null)
				{
					_normalRootOpacity = (CFloat) CR2WTypeManager.Create("Float", "normalRootOpacity", cr2w, this);
				}
				return _normalRootOpacity;
			}
			set
			{
				if (_normalRootOpacity == value)
				{
					return;
				}
				_normalRootOpacity = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("hoverRootOpacity")] 
		public CFloat HoverRootOpacity
		{
			get
			{
				if (_hoverRootOpacity == null)
				{
					_hoverRootOpacity = (CFloat) CR2WTypeManager.Create("Float", "hoverRootOpacity", cr2w, this);
				}
				return _hoverRootOpacity;
			}
			set
			{
				if (_hoverRootOpacity == value)
				{
					return;
				}
				_hoverRootOpacity = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
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

		[Ordinal(23)] 
		[RED("animTarget_Hover")] 
		public wCHandle<inkWidget> AnimTarget_Hover
		{
			get
			{
				if (_animTarget_Hover == null)
				{
					_animTarget_Hover = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "animTarget_Hover", cr2w, this);
				}
				return _animTarget_Hover;
			}
			set
			{
				if (_animTarget_Hover == value)
				{
					return;
				}
				_animTarget_Hover = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("animTarget_Pulse")] 
		public wCHandle<inkWidget> AnimTarget_Pulse
		{
			get
			{
				if (_animTarget_Pulse == null)
				{
					_animTarget_Pulse = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "animTarget_Pulse", cr2w, this);
				}
				return _animTarget_Pulse;
			}
			set
			{
				if (_animTarget_Pulse == value)
				{
					return;
				}
				_animTarget_Pulse = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("animHover")] 
		public CHandle<inkanimDefinition> AnimHover
		{
			get
			{
				if (_animHover == null)
				{
					_animHover = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "animHover", cr2w, this);
				}
				return _animHover;
			}
			set
			{
				if (_animHover == value)
				{
					return;
				}
				_animHover = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("animPulse")] 
		public CHandle<inkanimDefinition> AnimPulse
		{
			get
			{
				if (_animPulse == null)
				{
					_animPulse = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "animPulse", cr2w, this);
				}
				return _animPulse;
			}
			set
			{
				if (_animPulse == value)
				{
					return;
				}
				_animPulse = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("animHoverProxy")] 
		public CHandle<inkanimProxy> AnimHoverProxy
		{
			get
			{
				if (_animHoverProxy == null)
				{
					_animHoverProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animHoverProxy", cr2w, this);
				}
				return _animHoverProxy;
			}
			set
			{
				if (_animHoverProxy == value)
				{
					return;
				}
				_animHoverProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("animPulseProxy")] 
		public CHandle<inkanimProxy> AnimPulseProxy
		{
			get
			{
				if (_animPulseProxy == null)
				{
					_animPulseProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animPulseProxy", cr2w, this);
				}
				return _animPulseProxy;
			}
			set
			{
				if (_animPulseProxy == value)
				{
					return;
				}
				_animPulseProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("animPulseOptions")] 
		public inkanimPlaybackOptions AnimPulseOptions
		{
			get
			{
				if (_animPulseOptions == null)
				{
					_animPulseOptions = (inkanimPlaybackOptions) CR2WTypeManager.Create("inkanimPlaybackOptions", "animPulseOptions", cr2w, this);
				}
				return _animPulseOptions;
			}
			set
			{
				if (_animPulseOptions == value)
				{
					return;
				}
				_animPulseOptions = value;
				PropertySet(this);
			}
		}

		public AnimatedListItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
