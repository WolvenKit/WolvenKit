using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_CameraRecoil : animAnimFeature
	{
		[Ordinal(0)]  [RED("backward_offset")] public CFloat Backward_offset { get; set; }
		[Ordinal(1)]  [RED("side_offset")] public CFloat Side_offset { get; set; }
		[Ordinal(2)]  [RED("tilt_angle")] public CFloat Tilt_angle { get; set; }
		[Ordinal(3)]  [RED("yaw_angle")] public CFloat Yaw_angle { get; set; }
		[Ordinal(4)]  [RED("pitch_angle")] public CFloat Pitch_angle { get; set; }
		[Ordinal(5)]  [RED("translate_transform_speed")] public CFloat Translate_transform_speed { get; set; }
		[Ordinal(6)]  [RED("rotate_transform_speed")] public CFloat Rotate_transform_speed { get; set; }
		[Ordinal(7)]  [RED("is_offset")] public CBool Is_offset { get; set; }

		public AnimFeature_CameraRecoil(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
