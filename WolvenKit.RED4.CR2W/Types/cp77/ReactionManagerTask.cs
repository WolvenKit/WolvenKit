using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ReactionManagerTask : AIbehaviortaskScript
	{
		[Ordinal(0)] [RED("reactionData")] public CHandle<AIReactionData> ReactionData { get; set; }

		public ReactionManagerTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
