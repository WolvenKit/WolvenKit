using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GameTimeWrapper : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("gameTime")] 
		public GameTime GameTime
		{
			get => GetPropertyValue<GameTime>();
			set => SetPropertyValue<GameTime>(value);
		}

		public GameTimeWrapper()
		{
			GameTime = new();
		}
	}
}
