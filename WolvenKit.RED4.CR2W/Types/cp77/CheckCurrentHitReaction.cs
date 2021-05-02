using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CheckCurrentHitReaction : HitConditions
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

		public CheckCurrentHitReaction(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
