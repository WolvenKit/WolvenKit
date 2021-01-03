using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldSpeedSplineNodeOrientationChangeSection : CVariable
	{
		[Ordinal(0)]  [RED("pos")] public CFloat Pos { get; set; }
		[Ordinal(1)]  [RED("targetOrientation")] public EulerAngles TargetOrientation { get; set; }
		[Ordinal(2)]  [RED("type")] public CEnum<worldSpeedSplineOrientationMarkerType> Type { get; set; }

		public worldSpeedSplineNodeOrientationChangeSection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
