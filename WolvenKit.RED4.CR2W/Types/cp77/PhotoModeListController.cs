using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PhotoModeListController : inkListController
	{
		private inkWidgetReference _logoWidget;
		private inkVerticalPanelWidgetReference _panel;
		private CHandle<inkanimProxy> _fadeAnim;
		private CBool _isAnimating;
		private CFloat _animationTime;
		private CFloat _animationTarget;
		private CFloat _elementsAnimationTime;
		private CFloat _elementsAnimationDelay;
		private CInt32 _currentElementAnimation;

		[Ordinal(6)] 
		[RED("LogoWidget")] 
		public inkWidgetReference LogoWidget
		{
			get
			{
				if (_logoWidget == null)
				{
					_logoWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "LogoWidget", cr2w, this);
				}
				return _logoWidget;
			}
			set
			{
				if (_logoWidget == value)
				{
					return;
				}
				_logoWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("Panel")] 
		public inkVerticalPanelWidgetReference Panel
		{
			get
			{
				if (_panel == null)
				{
					_panel = (inkVerticalPanelWidgetReference) CR2WTypeManager.Create("inkVerticalPanelWidgetReference", "Panel", cr2w, this);
				}
				return _panel;
			}
			set
			{
				if (_panel == value)
				{
					return;
				}
				_panel = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("fadeAnim")] 
		public CHandle<inkanimProxy> FadeAnim
		{
			get
			{
				if (_fadeAnim == null)
				{
					_fadeAnim = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "fadeAnim", cr2w, this);
				}
				return _fadeAnim;
			}
			set
			{
				if (_fadeAnim == value)
				{
					return;
				}
				_fadeAnim = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("isAnimating")] 
		public CBool IsAnimating
		{
			get
			{
				if (_isAnimating == null)
				{
					_isAnimating = (CBool) CR2WTypeManager.Create("Bool", "isAnimating", cr2w, this);
				}
				return _isAnimating;
			}
			set
			{
				if (_isAnimating == value)
				{
					return;
				}
				_isAnimating = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("animationTime")] 
		public CFloat AnimationTime
		{
			get
			{
				if (_animationTime == null)
				{
					_animationTime = (CFloat) CR2WTypeManager.Create("Float", "animationTime", cr2w, this);
				}
				return _animationTime;
			}
			set
			{
				if (_animationTime == value)
				{
					return;
				}
				_animationTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("animationTarget")] 
		public CFloat AnimationTarget
		{
			get
			{
				if (_animationTarget == null)
				{
					_animationTarget = (CFloat) CR2WTypeManager.Create("Float", "animationTarget", cr2w, this);
				}
				return _animationTarget;
			}
			set
			{
				if (_animationTarget == value)
				{
					return;
				}
				_animationTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("elementsAnimationTime")] 
		public CFloat ElementsAnimationTime
		{
			get
			{
				if (_elementsAnimationTime == null)
				{
					_elementsAnimationTime = (CFloat) CR2WTypeManager.Create("Float", "elementsAnimationTime", cr2w, this);
				}
				return _elementsAnimationTime;
			}
			set
			{
				if (_elementsAnimationTime == value)
				{
					return;
				}
				_elementsAnimationTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("elementsAnimationDelay")] 
		public CFloat ElementsAnimationDelay
		{
			get
			{
				if (_elementsAnimationDelay == null)
				{
					_elementsAnimationDelay = (CFloat) CR2WTypeManager.Create("Float", "elementsAnimationDelay", cr2w, this);
				}
				return _elementsAnimationDelay;
			}
			set
			{
				if (_elementsAnimationDelay == value)
				{
					return;
				}
				_elementsAnimationDelay = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("currentElementAnimation")] 
		public CInt32 CurrentElementAnimation
		{
			get
			{
				if (_currentElementAnimation == null)
				{
					_currentElementAnimation = (CInt32) CR2WTypeManager.Create("Int32", "currentElementAnimation", cr2w, this);
				}
				return _currentElementAnimation;
			}
			set
			{
				if (_currentElementAnimation == value)
				{
					return;
				}
				_currentElementAnimation = value;
				PropertySet(this);
			}
		}

		public PhotoModeListController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
