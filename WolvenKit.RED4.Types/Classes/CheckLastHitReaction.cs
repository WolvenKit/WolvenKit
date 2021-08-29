using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CheckLastHitReaction : HitConditions
	{
		private CEnum<animHitReactionType> _hitReactionToCheck;

		[Ordinal(0)] 
		[RED("hitReactionToCheck")] 
		public CEnum<animHitReactionType> HitReactionToCheck
		{
			get => GetProperty(ref _hitReactionToCheck);
			set => SetProperty(ref _hitReactionToCheck, value);
		}
	}
}
