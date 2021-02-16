using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_CameraBodyOffset : animAnimFeature
	{
		[Ordinal(0)] [RED("lookat_pitch_forward_offset")] public CFloat Lookat_pitch_forward_offset { get; set; }
		[Ordinal(1)] [RED("lookat_pitch_forward_down_ratio")] public CFloat Lookat_pitch_forward_down_ratio { get; set; }
		[Ordinal(2)] [RED("lookat_yaw_left_offset")] public CFloat Lookat_yaw_left_offset { get; set; }
		[Ordinal(3)] [RED("lookat_yaw_left_up_offset")] public CFloat Lookat_yaw_left_up_offset { get; set; }
		[Ordinal(4)] [RED("lookat_yaw_right_offset")] public CFloat Lookat_yaw_right_offset { get; set; }
		[Ordinal(5)] [RED("lookat_yaw_right_up_offset")] public CFloat Lookat_yaw_right_up_offset { get; set; }
		[Ordinal(6)] [RED("lookat_yaw_offset_active_angle")] public CFloat Lookat_yaw_offset_active_angle { get; set; }
		[Ordinal(7)] [RED("is_paralax")] public CFloat Is_paralax { get; set; }
		[Ordinal(8)] [RED("paralax_radius")] public CFloat Paralax_radius { get; set; }
		[Ordinal(9)] [RED("paralax_forward_offset")] public CFloat Paralax_forward_offset { get; set; }
		[Ordinal(10)] [RED("lookat_offset_vertical")] public CFloat Lookat_offset_vertical { get; set; }

		public AnimFeature_CameraBodyOffset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
