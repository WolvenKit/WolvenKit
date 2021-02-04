using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SplinePoint : CVariable
	{
		[Ordinal(0)]  [RED("position")] public Vector3 Position { get; set; }
		[Ordinal(1)]  [RED("rotation")] public Quaternion Rotation { get; set; }
		[Ordinal(2)]  [RED("tangents", 2)] public CArrayFixedSize<Vector3> Tangents { get; set; }
		[Ordinal(3)]  [RED("continuousTangents")] public CBool ContinuousTangents { get; set; }
		[Ordinal(4)]  [RED("automaticTangents")] public CBool AutomaticTangents { get; set; }
		[Ordinal(5)]  [RED("id")] public CUInt32 Id { get; set; }

		public SplinePoint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
