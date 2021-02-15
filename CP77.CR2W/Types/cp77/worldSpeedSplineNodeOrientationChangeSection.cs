using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldSpeedSplineNodeOrientationChangeSection : CVariable
	{
		[Ordinal(0)] [RED("pos")] public CFloat Pos { get; set; }
		[Ordinal(1)] [RED("type")] public CEnum<worldSpeedSplineOrientationMarkerType> Type { get; set; }
		[Ordinal(2)] [RED("targetOrientation")] public EulerAngles TargetOrientation { get; set; }

		public worldSpeedSplineNodeOrientationChangeSection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
