using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RevealAccessPointPrereqState : gamePrereqState
	{
		[Ordinal(0)] 
		[RED("listener")] 
		public CHandle<GameObjectListener> Listener
		{
			get => GetPropertyValue<CHandle<GameObjectListener>>();
			set => SetPropertyValue<CHandle<GameObjectListener>>(value);
		}

		public RevealAccessPointPrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
