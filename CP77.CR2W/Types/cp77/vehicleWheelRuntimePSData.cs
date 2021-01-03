using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class vehicleWheelRuntimePSData : CVariable
	{
		[Ordinal(0)]  [RED("previousDampedSpringForce")] public CFloat PreviousDampedSpringForce { get; set; }
		[Ordinal(1)]  [RED("previousLogicalSpringCompression")] public CFloat PreviousLogicalSpringCompression { get; set; }
		[Ordinal(2)]  [RED("previousSwaybarDisplacement")] public CFloat PreviousSwaybarDisplacement { get; set; }
		[Ordinal(3)]  [RED("previousTouchedMaterial")] public CName PreviousTouchedMaterial { get; set; }
		[Ordinal(4)]  [RED("previousVisualDisplacement")] public CFloat PreviousVisualDisplacement { get; set; }

		public vehicleWheelRuntimePSData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
