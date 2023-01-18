using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LastHitDataEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("hitReactionBehaviorData")] 
		public CHandle<HitReactionBehaviorData> HitReactionBehaviorData
		{
			get => GetPropertyValue<CHandle<HitReactionBehaviorData>>();
			set => SetPropertyValue<CHandle<HitReactionBehaviorData>>(value);
		}

		public LastHitDataEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
