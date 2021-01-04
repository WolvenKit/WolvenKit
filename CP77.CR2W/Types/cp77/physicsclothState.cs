using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class physicsclothState : CVariable
	{
		[Ordinal(0)]  [RED("bendPhaseData")] public physicsclothPhaseConfig BendPhaseData { get; set; }
		[Ordinal(1)]  [RED("horizontalPhaseData")] public physicsclothPhaseConfig HorizontalPhaseData { get; set; }
		[Ordinal(2)]  [RED("runtimeInfo")] public physicsclothRuntimeInfo RuntimeInfo { get; set; }
		[Ordinal(3)]  [RED("shearPhaseData")] public physicsclothPhaseConfig ShearPhaseData { get; set; }
		[Ordinal(4)]  [RED("verticalPhaseData")] public physicsclothPhaseConfig VerticalPhaseData { get; set; }

		public physicsclothState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
