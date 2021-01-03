using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ReactionManagerTask : AIbehaviortaskScript
	{
		[Ordinal(0)]  [RED("reactionData")] public CHandle<AIReactionData> ReactionData { get; set; }

		public ReactionManagerTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
