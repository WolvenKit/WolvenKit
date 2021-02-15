using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animLookAtPreset_EyesHeadWithBodyFree : animLookAtPreset
	{
		[Ordinal(0)] [RED("suppressHeadAnimation")] public CFloat SuppressHeadAnimation { get; set; }
		[Ordinal(1)] [RED("headMobility")] public CFloat HeadMobility { get; set; }
		[Ordinal(2)] [RED("suppressChestAnimation")] public CFloat SuppressChestAnimation { get; set; }
		[Ordinal(3)] [RED("chestMobility")] public CFloat ChestMobility { get; set; }
		[Ordinal(4)] [RED("softLimitAngle")] public CFloat SoftLimitAngle { get; set; }

		public animLookAtPreset_EyesHeadWithBodyFree(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
