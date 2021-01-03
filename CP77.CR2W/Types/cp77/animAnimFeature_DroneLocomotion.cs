using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_DroneLocomotion : animAnimFeature
	{
		[Ordinal(0)]  [RED("angularSpeed")] public CFloat AngularSpeed { get; set; }
		[Ordinal(1)]  [RED("desiredSpeed")] public CFloat DesiredSpeed { get; set; }
		[Ordinal(2)]  [RED("lookAtAngle")] public CFloat LookAtAngle { get; set; }
		[Ordinal(3)]  [RED("pathCurvative")] public CFloat PathCurvative { get; set; }
		[Ordinal(4)]  [RED("speed")] public CFloat Speed { get; set; }

		public animAnimFeature_DroneLocomotion(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
