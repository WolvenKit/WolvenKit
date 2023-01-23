using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SecondHeartStatListener : gameScriptStatsListener
	{
		[Ordinal(0)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		public SecondHeartStatListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
