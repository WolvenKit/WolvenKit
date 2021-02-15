using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entDynamicActorRepellingComponent : entIPlacedComponent
	{
		[Ordinal(5)] [RED("type")] public CEnum<entRepellingType> Type { get; set; }
		[Ordinal(6)] [RED("shape")] public CEnum<entRepellingShape> Shape { get; set; }
		[Ordinal(7)] [RED("magnitude")] public CFloat Magnitude { get; set; }
		[Ordinal(8)] [RED("bendIntensity")] public CFloat BendIntensity { get; set; }
		[Ordinal(9)] [RED("anchorPointVert")] public CEnum<rendWindShapeAnchorPointVert> AnchorPointVert { get; set; }
		[Ordinal(10)] [RED("anchorPointHorz")] public CEnum<rendWindShapeAnchorPointHorz> AnchorPointHorz { get; set; }
		[Ordinal(11)] [RED("anchorPointDepth")] public CEnum<rendWindShapeAnchorPointDepth> AnchorPointDepth { get; set; }
		[Ordinal(12)] [RED("radius")] public CFloat Radius { get; set; }
		[Ordinal(13)] [RED("capsuleRadius")] public CFloat CapsuleRadius { get; set; }
		[Ordinal(14)] [RED("capsuleHeight")] public CFloat CapsuleHeight { get; set; }

		public entDynamicActorRepellingComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
