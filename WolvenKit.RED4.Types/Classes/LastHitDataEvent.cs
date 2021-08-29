using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LastHitDataEvent : redEvent
	{
		private CHandle<HitReactionBehaviorData> _hitReactionBehaviorData;

		[Ordinal(0)] 
		[RED("hitReactionBehaviorData")] 
		public CHandle<HitReactionBehaviorData> HitReactionBehaviorData
		{
			get => GetProperty(ref _hitReactionBehaviorData);
			set => SetProperty(ref _hitReactionBehaviorData, value);
		}
	}
}
