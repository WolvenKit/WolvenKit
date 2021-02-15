using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_SecurityTurretData : animAnimFeature
	{
		[Ordinal(0)] [RED("Shoot")] public CBool Shoot { get; set; }
		[Ordinal(1)] [RED("isRippedOff")] public CBool IsRippedOff { get; set; }
		[Ordinal(2)] [RED("ripOffSide")] public CBool RipOffSide { get; set; }
		[Ordinal(3)] [RED("isOverriden")] public CBool IsOverriden { get; set; }

		public AnimFeature_SecurityTurretData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
