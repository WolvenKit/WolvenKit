using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CheckReactionValueThreshold : AIbehaviorconditionScript
	{
		private CEnum<EReactionValue> _reactionValue;

		[Ordinal(0)] 
		[RED("reactionValue")] 
		public CEnum<EReactionValue> ReactionValue
		{
			get => GetProperty(ref _reactionValue);
			set => SetProperty(ref _reactionValue, value);
		}

		public CheckReactionValueThreshold(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
