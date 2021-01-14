using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIMoveCommand : AICommand
	{
		[Ordinal(0)]  [RED("alwaysUseStealth")] public CBool AlwaysUseStealth { get; set; }
		[Ordinal(1)]  [RED("ignoreInCombat")] public CBool IgnoreInCombat { get; set; }
		[Ordinal(2)]  [RED("removeAfterCombat")] public CBool RemoveAfterCombat { get; set; }

		public AIMoveCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
