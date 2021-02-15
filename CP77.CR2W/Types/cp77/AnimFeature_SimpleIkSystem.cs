using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_SimpleIkSystem : animAnimFeature
	{
		[Ordinal(0)] [RED("isEnable")] public CBool IsEnable { get; set; }
		[Ordinal(1)] [RED("weight")] public CFloat Weight { get; set; }
		[Ordinal(2)] [RED("setPosition")] public CBool SetPosition { get; set; }
		[Ordinal(3)] [RED("position")] public Vector4 Position { get; set; }
		[Ordinal(4)] [RED("positionOffset")] public Vector4 PositionOffset { get; set; }
		[Ordinal(5)] [RED("setRotation")] public CBool SetRotation { get; set; }
		[Ordinal(6)] [RED("rotation")] public Quaternion Rotation { get; set; }
		[Ordinal(7)] [RED("rotationOffset")] public Quaternion RotationOffset { get; set; }

		public AnimFeature_SimpleIkSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
