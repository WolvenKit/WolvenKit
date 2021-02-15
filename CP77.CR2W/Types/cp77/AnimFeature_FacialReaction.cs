using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_FacialReaction : animAnimFeature
	{
		[Ordinal(0)] [RED("category")] public CInt32 Category { get; set; }
		[Ordinal(1)] [RED("idle")] public CInt32 Idle { get; set; }

		public AnimFeature_FacialReaction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
