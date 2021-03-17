using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InitializeUserScreenGameController : gameuiMenuGameController
	{
		private inkVideoWidgetReference _backgroundVideo;
		private wCHandle<inkMenuEventDispatcher> _menuEventDispatcher;

		[Ordinal(3)] 
		[RED("backgroundVideo")] 
		public inkVideoWidgetReference BackgroundVideo
		{
			get => GetProperty(ref _backgroundVideo);
			set => SetProperty(ref _backgroundVideo, value);
		}

		[Ordinal(4)] 
		[RED("menuEventDispatcher")] 
		public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetProperty(ref _menuEventDispatcher);
			set => SetProperty(ref _menuEventDispatcher, value);
		}

		public InitializeUserScreenGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
