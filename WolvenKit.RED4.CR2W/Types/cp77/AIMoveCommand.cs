using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIMoveCommand : AICommand
	{
		[Ordinal(4)] [RED("removeAfterCombat")] public CBool RemoveAfterCombat { get; set; }
		[Ordinal(5)] [RED("ignoreInCombat")] public CBool IgnoreInCombat { get; set; }
		[Ordinal(6)] [RED("alwaysUseStealth")] public CBool AlwaysUseStealth { get; set; }

		public AIMoveCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
