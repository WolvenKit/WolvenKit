using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnChoiceNodeNsAdaptiveLookAtReferencePoint : CVariable
	{
		[Ordinal(0)]  [RED("constantWeight")] public CFloat ConstantWeight { get; set; }
		[Ordinal(1)]  [RED("referencePoint")] public scnReferencePointId ReferencePoint { get; set; }

		public scnChoiceNodeNsAdaptiveLookAtReferencePoint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
