using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SBokehDofParams : CVariable
	{
		[Ordinal(0)]  [RED("bokehSizeMuliplier")] public CFloat BokehSizeMuliplier { get; set; }
		[Ordinal(1)]  [RED("enabled")] public CBool Enabled { get; set; }
		[Ordinal(2)]  [RED("fStops")] public CEnum<EApertureValue> FStops { get; set; }
		[Ordinal(3)]  [RED("hexToCircleScale")] public CFloat HexToCircleScale { get; set; }
		[Ordinal(4)]  [RED("planeInFocus")] public CFloat PlaneInFocus { get; set; }
		[Ordinal(5)]  [RED("usePhysicalSetup")] public CBool UsePhysicalSetup { get; set; }

		public SBokehDofParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
