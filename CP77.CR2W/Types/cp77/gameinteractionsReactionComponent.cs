using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsReactionComponent : entIComponent
	{
		[Ordinal(0)]  [RED("reactions")] public CArray<gameinteractionsReactionData> Reactions { get; set; }
		[Ordinal(1)]  [RED("triggerAutomatically")] public CBool TriggerAutomatically { get; set; }

		public gameinteractionsReactionComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
