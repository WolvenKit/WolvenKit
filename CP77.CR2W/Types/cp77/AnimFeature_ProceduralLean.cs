using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_ProceduralLean : animAnimFeature
	{
		[Ordinal(0)]  [RED("angle_threshold")] public CFloat Angle_threshold { get; set; }
		[Ordinal(1)]  [RED("arms_counter_turn")] public CFloat Arms_counter_turn { get; set; }
		[Ordinal(2)]  [RED("damp_value_sprint")] public CFloat Damp_value_sprint { get; set; }
		[Ordinal(3)]  [RED("damp_value_walk")] public CFloat Damp_value_walk { get; set; }
		[Ordinal(4)]  [RED("hips_shift_down")] public CFloat Hips_shift_down { get; set; }
		[Ordinal(5)]  [RED("hips_shift_side")] public CFloat Hips_shift_side { get; set; }
		[Ordinal(6)]  [RED("hips_tilt")] public CFloat Hips_tilt { get; set; }
		[Ordinal(7)]  [RED("hips_turn")] public CFloat Hips_turn { get; set; }
		[Ordinal(8)]  [RED("max_turn_angle")] public CFloat Max_turn_angle { get; set; }
		[Ordinal(9)]  [RED("spine_tilt")] public CFloat Spine_tilt { get; set; }
		[Ordinal(10)]  [RED("spine_turn")] public CFloat Spine_turn { get; set; }
		[Ordinal(11)]  [RED("transform_multiplyer")] public CFloat Transform_multiplyer { get; set; }

		public AnimFeature_ProceduralLean(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
