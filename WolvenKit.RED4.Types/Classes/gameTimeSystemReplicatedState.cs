using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameTimeSystemReplicatedState : gameIGameSystemReplicatedState
	{
		private CBool _paused;
		private GameTime _gameTime;

		[Ordinal(0)] 
		[RED("paused")] 
		public CBool Paused
		{
			get => GetProperty(ref _paused);
			set => SetProperty(ref _paused, value);
		}

		[Ordinal(1)] 
		[RED("gameTime")] 
		public GameTime GameTime
		{
			get => GetProperty(ref _gameTime);
			set => SetProperty(ref _gameTime, value);
		}
	}
}
