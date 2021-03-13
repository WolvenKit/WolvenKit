using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CheckReactionValueThreshold : AIbehaviorconditionScript
	{
		[Ordinal(0)] [RED("reactionValue")] public CEnum<EReactionValue> ReactionValue { get; set; }

		public CheckReactionValueThreshold(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
