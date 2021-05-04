using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CheckReaction : AIbehaviorconditionScript
	{
		private CEnum<gamedataOutput> _reactionToCompare;

		[Ordinal(0)] 
		[RED("reactionToCompare")] 
		public CEnum<gamedataOutput> ReactionToCompare
		{
			get => GetProperty(ref _reactionToCompare);
			set => SetProperty(ref _reactionToCompare, value);
		}

		public CheckReaction(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
