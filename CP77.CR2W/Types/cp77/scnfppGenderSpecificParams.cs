using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnfppGenderSpecificParams : CVariable
	{
		[Ordinal(0)] [RED("genderMask")] public scnGenderMask GenderMask { get; set; }
		[Ordinal(1)] [RED("transitionBlendInTrajectorySpaceAngles")] public CArray<EulerAngles> TransitionBlendInTrajectorySpaceAngles { get; set; }
		[Ordinal(2)] [RED("transitionBlendInCameraSpace")] public CArray<CFloat> TransitionBlendInCameraSpace { get; set; }
		[Ordinal(3)] [RED("transitionEndInputAngles")] public CArray<EulerAngles> TransitionEndInputAngles { get; set; }
		[Ordinal(4)] [RED("idleCameraLs")] public EulerAngles IdleCameraLs { get; set; }
		[Ordinal(5)] [RED("idleControlCameraMs")] public EulerAngles IdleControlCameraMs { get; set; }

		public scnfppGenderSpecificParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
