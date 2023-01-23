using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PlayerCompanionCacheDataEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("isPlayerCompanionCached")] 
		public CBool IsPlayerCompanionCached
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("isPlayerCompanionCachedTimeStamp")] 
		public CFloat IsPlayerCompanionCachedTimeStamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public PlayerCompanionCacheDataEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
