using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HitReactionBehaviorData : IScriptable
	{
		private CEnum<animHitReactionType> _hitReactionType;
		private CFloat _hitReactionActivationTimeStamp;
		private CFloat _hitReactionDuration;

		[Ordinal(0)] 
		[RED("hitReactionType")] 
		public CEnum<animHitReactionType> HitReactionType
		{
			get => GetProperty(ref _hitReactionType);
			set => SetProperty(ref _hitReactionType, value);
		}

		[Ordinal(1)] 
		[RED("hitReactionActivationTimeStamp")] 
		public CFloat HitReactionActivationTimeStamp
		{
			get => GetProperty(ref _hitReactionActivationTimeStamp);
			set => SetProperty(ref _hitReactionActivationTimeStamp, value);
		}

		[Ordinal(2)] 
		[RED("hitReactionDuration")] 
		public CFloat HitReactionDuration
		{
			get => GetProperty(ref _hitReactionDuration);
			set => SetProperty(ref _hitReactionDuration, value);
		}
	}
}
