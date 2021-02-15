using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_DroneProcedural : animAnimFeature
	{
		[Ordinal(0)] [RED("mass")] public CFloat Mass { get; set; }
		[Ordinal(1)] [RED("size_front")] public CFloat Size_front { get; set; }
		[Ordinal(2)] [RED("size_back")] public CFloat Size_back { get; set; }
		[Ordinal(3)] [RED("size_left")] public CFloat Size_left { get; set; }
		[Ordinal(4)] [RED("size_right")] public CFloat Size_right { get; set; }
		[Ordinal(5)] [RED("walk_tilt_coef")] public CFloat Walk_tilt_coef { get; set; }
		[Ordinal(6)] [RED("mass_normalized_coef")] public CFloat Mass_normalized_coef { get; set; }
		[Ordinal(7)] [RED("tilt_angle_on_speed")] public CFloat Tilt_angle_on_speed { get; set; }
		[Ordinal(8)] [RED("speed_idle_threshold")] public CFloat Speed_idle_threshold { get; set; }
		[Ordinal(9)] [RED("starting_recovery_ballance")] public CFloat Starting_recovery_ballance { get; set; }
		[Ordinal(10)] [RED("pseudo_acceleration")] public CFloat Pseudo_acceleration { get; set; }
		[Ordinal(11)] [RED("turn_inertia_damping")] public CFloat Turn_inertia_damping { get; set; }
		[Ordinal(12)] [RED("combat_default_z_offset")] public CFloat Combat_default_z_offset { get; set; }

		public AnimFeature_DroneProcedural(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
