using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animLookAtAdditionalPreset_RightArm : animLookAtAdditionalPreset
	{
		[Ordinal(0)]  [RED("isAiming")] public CBool IsAiming { get; set; }
		[Ordinal(1)]  [RED("softLimitAngle")] public CFloat SoftLimitAngle { get; set; }

		public animLookAtAdditionalPreset_RightArm(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
