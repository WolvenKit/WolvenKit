using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnChoiceNodeNsAdaptiveLookAtReferencePoint : CVariable
	{
		[Ordinal(0)] [RED("referencePoint")] public scnReferencePointId ReferencePoint { get; set; }
		[Ordinal(1)] [RED("constantWeight")] public CFloat ConstantWeight { get; set; }

		public scnChoiceNodeNsAdaptiveLookAtReferencePoint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
