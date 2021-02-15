using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animPoleVectorDetails : CVariable
	{
		[Ordinal(0)] [RED("targetBone")] public animTransformIndex TargetBone { get; set; }
		[Ordinal(1)] [RED("positionOffset")] public Vector3 PositionOffset { get; set; }

		public animPoleVectorDetails(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
