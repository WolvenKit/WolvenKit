using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiTutorialOverlayLogicController : inkWidgetLogicController
	{
		private CBool _hideInMenu;
		private CBool _hideOnInput;
		private CName _showAnimation;
		private CName _hideAnimation;
		private CHandle<inkanimProxy> _animProxy;
		private wCHandle<questTutorialManager> _tutorialManager;

		[Ordinal(1)] 
		[RED("hideInMenu")] 
		public CBool HideInMenu
		{
			get
			{
				if (_hideInMenu == null)
				{
					_hideInMenu = (CBool) CR2WTypeManager.Create("Bool", "hideInMenu", cr2w, this);
				}
				return _hideInMenu;
			}
			set
			{
				if (_hideInMenu == value)
				{
					return;
				}
				_hideInMenu = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("hideOnInput")] 
		public CBool HideOnInput
		{
			get
			{
				if (_hideOnInput == null)
				{
					_hideOnInput = (CBool) CR2WTypeManager.Create("Bool", "hideOnInput", cr2w, this);
				}
				return _hideOnInput;
			}
			set
			{
				if (_hideOnInput == value)
				{
					return;
				}
				_hideOnInput = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("showAnimation")] 
		public CName ShowAnimation
		{
			get
			{
				if (_showAnimation == null)
				{
					_showAnimation = (CName) CR2WTypeManager.Create("CName", "showAnimation", cr2w, this);
				}
				return _showAnimation;
			}
			set
			{
				if (_showAnimation == value)
				{
					return;
				}
				_showAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("hideAnimation")] 
		public CName HideAnimation
		{
			get
			{
				if (_hideAnimation == null)
				{
					_hideAnimation = (CName) CR2WTypeManager.Create("CName", "hideAnimation", cr2w, this);
				}
				return _hideAnimation;
			}
			set
			{
				if (_hideAnimation == value)
				{
					return;
				}
				_hideAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get
			{
				if (_animProxy == null)
				{
					_animProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animProxy", cr2w, this);
				}
				return _animProxy;
			}
			set
			{
				if (_animProxy == value)
				{
					return;
				}
				_animProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("tutorialManager")] 
		public wCHandle<questTutorialManager> TutorialManager
		{
			get
			{
				if (_tutorialManager == null)
				{
					_tutorialManager = (wCHandle<questTutorialManager>) CR2WTypeManager.Create("whandle:questTutorialManager", "tutorialManager", cr2w, this);
				}
				return _tutorialManager;
			}
			set
			{
				if (_tutorialManager == value)
				{
					return;
				}
				_tutorialManager = value;
				PropertySet(this);
			}
		}

		public gameuiTutorialOverlayLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
