using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsReactionComponent : entIComponent
	{
		[Ordinal(0)]  [RED("reactions")] public CArray<gameinteractionsReactionData> Reactions { get; set; }
		[Ordinal(1)]  [RED("triggerAutomatically")] public CBool TriggerAutomatically { get; set; }

		public gameinteractionsReactionComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
