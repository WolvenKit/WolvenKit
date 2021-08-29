using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GameTimeWrapper : RedBaseClass
	{
		private GameTime _gameTime;

		[Ordinal(0)] 
		[RED("gameTime")] 
		public GameTime GameTime
		{
			get => GetProperty(ref _gameTime);
			set => SetProperty(ref _gameTime, value);
		}
	}
}
