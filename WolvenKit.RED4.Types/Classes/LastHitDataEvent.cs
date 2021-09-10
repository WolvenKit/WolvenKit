using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LastHitDataEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("hitReactionBehaviorData")] 
		public CHandle<HitReactionBehaviorData> HitReactionBehaviorData
		{
			get => GetPropertyValue<CHandle<HitReactionBehaviorData>>();
			set => SetPropertyValue<CHandle<HitReactionBehaviorData>>(value);
		}
	}
}
