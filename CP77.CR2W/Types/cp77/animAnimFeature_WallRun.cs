using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_WallRun : animAnimFeature
	{
		[Ordinal(0)] [RED("wallOnRightSide")] public CBool WallOnRightSide { get; set; }
		[Ordinal(1)] [RED("wallPosition")] public Vector4 WallPosition { get; set; }
		[Ordinal(2)] [RED("wallNormal")] public Vector4 WallNormal { get; set; }

		public animAnimFeature_WallRun(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
