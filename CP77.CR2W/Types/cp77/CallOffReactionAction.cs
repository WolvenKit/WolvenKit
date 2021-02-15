using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CallOffReactionAction : SquadTask
	{
		[Ordinal(0)] [RED("squadActionName")] public CEnum<EAISquadAction> SquadActionName { get; set; }

		public CallOffReactionAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
