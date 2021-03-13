using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_BasicAim : animAnimFeature
	{
		[Ordinal(0)] [RED("aimState")] public CInt32 AimState { get; set; }
		[Ordinal(1)] [RED("zoomState")] public CInt32 ZoomState { get; set; }

		public animAnimFeature_BasicAim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
