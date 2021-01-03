using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_CameraGameplay : animAnimFeature
	{
		[Ordinal(0)]  [RED("forward_offset_value")] public CFloat Forward_offset_value { get; set; }
		[Ordinal(1)]  [RED("is_forward_offset")] public CFloat Is_forward_offset { get; set; }
		[Ordinal(2)]  [RED("is_pitch_off")] public CFloat Is_pitch_off { get; set; }
		[Ordinal(3)]  [RED("is_yaw_off")] public CFloat Is_yaw_off { get; set; }
		[Ordinal(4)]  [RED("upperbody_pitch_weight")] public CFloat Upperbody_pitch_weight { get; set; }
		[Ordinal(5)]  [RED("upperbody_yaw_weight")] public CFloat Upperbody_yaw_weight { get; set; }

		public AnimFeature_CameraGameplay(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
