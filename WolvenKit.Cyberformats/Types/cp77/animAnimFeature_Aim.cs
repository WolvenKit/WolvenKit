using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_Aim : animAnimFeature_BasicAim
	{
		[Ordinal(2)] [RED("aimPoint")] public Vector4 AimPoint { get; set; }

		public animAnimFeature_Aim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
