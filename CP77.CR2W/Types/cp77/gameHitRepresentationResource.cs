using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameHitRepresentationResource : CResource
	{
		[Ordinal(1)] [RED("representations")] public CArray<gameHitShapeContainer> Representations { get; set; }
		[Ordinal(2)] [RED("overrides")] public CArray<gameHitRepresentationVisualTaggedOverride> Overrides { get; set; }

		public gameHitRepresentationResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
