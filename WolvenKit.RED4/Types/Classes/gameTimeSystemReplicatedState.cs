using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameTimeSystemReplicatedState : gameIGameSystemReplicatedState
	{
		[Ordinal(0)] 
		[RED("paused")] 
		public CBool Paused
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("gameTime")] 
		public GameTime GameTime
		{
			get => GetPropertyValue<GameTime>();
			set => SetPropertyValue<GameTime>(value);
		}

		public gameTimeSystemReplicatedState()
		{
			GameTime = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
