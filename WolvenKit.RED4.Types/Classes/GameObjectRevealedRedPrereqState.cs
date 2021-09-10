using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GameObjectRevealedRedPrereqState : gamePrereqState
	{
		[Ordinal(0)] 
		[RED("listener")] 
		public CHandle<GameObjectListener> Listener
		{
			get => GetPropertyValue<CHandle<GameObjectListener>>();
			set => SetPropertyValue<CHandle<GameObjectListener>>(value);
		}
	}
}
