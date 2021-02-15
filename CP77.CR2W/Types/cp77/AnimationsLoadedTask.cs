using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AnimationsLoadedTask : AIbehaviortaskScript
	{
		[Ordinal(0)] [RED("coreAnims")] public CBool CoreAnims { get; set; }
		[Ordinal(1)] [RED("setSignal")] public CBool SetSignal { get; set; }
		[Ordinal(2)] [RED("melee")] public CBool Melee { get; set; }

		public AnimationsLoadedTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
