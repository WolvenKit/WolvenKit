using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsReactionComponent : entIComponent
	{
		[Ordinal(3)] [RED("reactions")] public CArray<gameinteractionsReactionData> Reactions { get; set; }
		[Ordinal(4)] [RED("triggerAutomatically")] public CBool TriggerAutomatically { get; set; }

		public gameinteractionsReactionComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
