using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GameTime : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("seconds")] 
		public CInt32 Seconds
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public GameTime()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
