using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SBokehDofParams : CVariable
	{
		[Ordinal(0)] [RED("enabled")] public CBool Enabled { get; set; }
		[Ordinal(1)] [RED("hexToCircleScale")] public CFloat HexToCircleScale { get; set; }
		[Ordinal(2)] [RED("usePhysicalSetup")] public CBool UsePhysicalSetup { get; set; }
		[Ordinal(3)] [RED("planeInFocus")] public CFloat PlaneInFocus { get; set; }
		[Ordinal(4)] [RED("fStops")] public CEnum<EApertureValue> FStops { get; set; }
		[Ordinal(5)] [RED("bokehSizeMuliplier")] public CFloat BokehSizeMuliplier { get; set; }

		public SBokehDofParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
