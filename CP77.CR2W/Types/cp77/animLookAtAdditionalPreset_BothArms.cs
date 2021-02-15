using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animLookAtAdditionalPreset_BothArms : animLookAtAdditionalPreset
	{
		[Ordinal(0)] [RED("rightHanded")] public CBool RightHanded { get; set; }
		[Ordinal(1)] [RED("softLimitAngle")] public CFloat SoftLimitAngle { get; set; }

		public animLookAtAdditionalPreset_BothArms(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
