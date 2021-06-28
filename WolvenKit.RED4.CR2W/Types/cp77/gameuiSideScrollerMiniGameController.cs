using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiSideScrollerMiniGameController : gameuiWidgetGameController
	{
		private inkWidgetReference _gameplayCanvas;
		private CName _gameName;

		[Ordinal(2)] 
		[RED("gameplayCanvas")] 
		public inkWidgetReference GameplayCanvas
		{
			get => GetProperty(ref _gameplayCanvas);
			set => SetProperty(ref _gameplayCanvas, value);
		}

		[Ordinal(3)] 
		[RED("gameName")] 
		public CName GameName
		{
			get => GetProperty(ref _gameName);
			set => SetProperty(ref _gameName, value);
		}

		public gameuiSideScrollerMiniGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
