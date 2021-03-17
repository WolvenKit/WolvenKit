using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiOnHitPlayerEvent : redEvent
	{
		private CHandle<gameuiMinigameState> _gameState;

		[Ordinal(0)] 
		[RED("gameState")] 
		public CHandle<gameuiMinigameState> GameState
		{
			get => GetProperty(ref _gameState);
			set => SetProperty(ref _gameState, value);
		}

		public gameuiOnHitPlayerEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
