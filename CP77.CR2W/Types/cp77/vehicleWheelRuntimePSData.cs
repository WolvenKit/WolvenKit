using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class vehicleWheelRuntimePSData : CVariable
	{
		[Ordinal(0)]  [RED("previousTouchedMaterial")] public CName PreviousTouchedMaterial { get; set; }
		[Ordinal(1)]  [RED("previousVisualDisplacement")] public CFloat PreviousVisualDisplacement { get; set; }
		[Ordinal(2)]  [RED("previousLogicalSpringCompression")] public CFloat PreviousLogicalSpringCompression { get; set; }
		[Ordinal(3)]  [RED("previousSwaybarDisplacement")] public CFloat PreviousSwaybarDisplacement { get; set; }
		[Ordinal(4)]  [RED("previousDampedSpringForce")] public CFloat PreviousDampedSpringForce { get; set; }

		public vehicleWheelRuntimePSData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
