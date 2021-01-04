using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animLookAtAdditionalPreset_RightArm : animLookAtAdditionalPreset
	{
		[Ordinal(0)]  [RED("isAiming")] public CBool IsAiming { get; set; }
		[Ordinal(1)]  [RED("softLimitAngle")] public CFloat SoftLimitAngle { get; set; }

		public animLookAtAdditionalPreset_RightArm(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
