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
			get => GetProperty(ref _hideInMenu);
			set => SetProperty(ref _hideInMenu, value);
		}

		[Ordinal(2)] 
		[RED("hideOnInput")] 
		public CBool HideOnInput
		{
			get => GetProperty(ref _hideOnInput);
			set => SetProperty(ref _hideOnInput, value);
		}

		[Ordinal(3)] 
		[RED("showAnimation")] 
		public CName ShowAnimation
		{
			get => GetProperty(ref _showAnimation);
			set => SetProperty(ref _showAnimation, value);
		}

		[Ordinal(4)] 
		[RED("hideAnimation")] 
		public CName HideAnimation
		{
			get => GetProperty(ref _hideAnimation);
			set => SetProperty(ref _hideAnimation, value);
		}

		[Ordinal(5)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetProperty(ref _animProxy);
			set => SetProperty(ref _animProxy, value);
		}

		[Ordinal(6)] 
		[RED("tutorialManager")] 
		public wCHandle<questTutorialManager> TutorialManager
		{
			get => GetProperty(ref _tutorialManager);
			set => SetProperty(ref _tutorialManager, value);
		}

		public gameuiTutorialOverlayLogicController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
