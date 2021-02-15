using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animCollisionRoundedShape_ : CVariable
	{
		[Ordinal(0)] [RED("bone")] public animTransformIndex Bone { get; set; }
		[Ordinal(1)] [RED("transformLS")] public QsTransform TransformLS { get; set; }
		[Ordinal(2)] [RED("roundedCornerRadius")] public CFloat RoundedCornerRadius { get; set; }
		[Ordinal(3)] [RED("xBoxExtent")] public CFloat XBoxExtent { get; set; }
		[Ordinal(4)] [RED("yBoxExtent")] public CFloat YBoxExtent { get; set; }
		[Ordinal(5)] [RED("zBoxExtent")] public CFloat ZBoxExtent { get; set; }

		public animCollisionRoundedShape_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
