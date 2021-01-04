using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_CombatGadget : animAnimFeature
	{
		[Ordinal(0)]  [RED("isDetonated")] public CBool IsDetonated { get; set; }
		[Ordinal(1)]  [RED("isQuickthrow")] public CBool IsQuickthrow { get; set; }

		public AnimFeature_CombatGadget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
