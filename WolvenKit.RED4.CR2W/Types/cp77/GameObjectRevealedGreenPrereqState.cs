using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GameObjectRevealedGreenPrereqState : gamePrereqState
	{
		private CHandle<GameObjectListener> _listener;

		[Ordinal(0)] 
		[RED("listener")] 
		public CHandle<GameObjectListener> Listener
		{
			get => GetProperty(ref _listener);
			set => SetProperty(ref _listener, value);
		}

		public GameObjectRevealedGreenPrereqState(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
