using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animLookAtPreset_EyesHead : animLookAtPreset
	{
		[Ordinal(0)]  [RED("headMobility")] public CFloat HeadMobility { get; set; }
		[Ordinal(1)]  [RED("softLimitAngle")] public CFloat SoftLimitAngle { get; set; }
		[Ordinal(2)]  [RED("suppressHeadAnimation")] public CFloat SuppressHeadAnimation { get; set; }

		public animLookAtPreset_EyesHead(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
