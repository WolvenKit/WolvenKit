using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CheckCurrentHitReaction : HitConditions
	{
		private CEnum<animHitReactionType> _hitReactionTypeToCompare;
		private CName _customStimNameToCompare;
		private CBool _shouldCheckDeathStimName;

		[Ordinal(0)] 
		[RED("HitReactionTypeToCompare")] 
		public CEnum<animHitReactionType> HitReactionTypeToCompare
		{
			get => GetProperty(ref _hitReactionTypeToCompare);
			set => SetProperty(ref _hitReactionTypeToCompare, value);
		}

		[Ordinal(1)] 
		[RED("CustomStimNameToCompare")] 
		public CName CustomStimNameToCompare
		{
			get => GetProperty(ref _customStimNameToCompare);
			set => SetProperty(ref _customStimNameToCompare, value);
		}

		[Ordinal(2)] 
		[RED("shouldCheckDeathStimName")] 
		public CBool ShouldCheckDeathStimName
		{
			get => GetProperty(ref _shouldCheckDeathStimName);
			set => SetProperty(ref _shouldCheckDeathStimName, value);
		}
	}
}
