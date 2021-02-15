using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameCursorInterpolationOverrides : inkUserData
	{
		[Ordinal(0)] [RED("minSpeed")] public Vector2 MinSpeed { get; set; }
		[Ordinal(1)] [RED("enterTime")] public CFloat EnterTime { get; set; }

		public gameCursorInterpolationOverrides(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
