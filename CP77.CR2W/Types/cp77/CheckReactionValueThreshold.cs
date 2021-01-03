using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CheckReactionValueThreshold : AIbehaviorconditionScript
	{
		[Ordinal(0)]  [RED("reactionValue")] public CEnum<EReactionValue> ReactionValue { get; set; }

		public CheckReactionValueThreshold(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
