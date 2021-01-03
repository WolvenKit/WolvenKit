using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SplinePoint : CVariable
	{
		[Ordinal(0)]  [RED("automaticTangents")] public CBool AutomaticTangents { get; set; }
		[Ordinal(1)]  [RED("continuousTangents")] public CBool ContinuousTangents { get; set; }
		[Ordinal(2)]  [RED("id")] public CUInt32 Id { get; set; }
		[Ordinal(3)]  [RED("position")] public Vector3 Position { get; set; }
		[Ordinal(4)]  [RED("rotation")] public Quaternion Rotation { get; set; }
		[Ordinal(5)]  [RED("tangents")] public [2]Vector3 Tangents { get; set; }

		public SplinePoint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
