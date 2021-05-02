using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiSideScrollerMiniGameControllerAdvanced : gameuiWidgetGameController
	{
		private inkWidgetReference _gameplayCanvas;

		[Ordinal(2)] 
		[RED("gameplayCanvas")] 
		public inkWidgetReference GameplayCanvas
		{
			get => GetProperty(ref _gameplayCanvas);
			set => SetProperty(ref _gameplayCanvas, value);
		}

		public gameuiSideScrollerMiniGameControllerAdvanced(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
