using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CheckLastHitReaction : HitConditions
	{
		private CEnum<animHitReactionType> _hitReactionToCheck;

		[Ordinal(0)] 
		[RED("hitReactionToCheck")] 
		public CEnum<animHitReactionType> HitReactionToCheck
		{
			get => GetProperty(ref _hitReactionToCheck);
			set => SetProperty(ref _hitReactionToCheck, value);
		}

		public CheckLastHitReaction(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
