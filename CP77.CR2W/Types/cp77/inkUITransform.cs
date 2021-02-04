using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkUITransform : CVariable
	{
		[Ordinal(0)]  [RED("translation")] public Vector2 Translation { get; set; }
		[Ordinal(1)]  [RED("scale")] public Vector2 Scale { get; set; }
		[Ordinal(2)]  [RED("shear")] public Vector2 Shear { get; set; }
		[Ordinal(3)]  [RED("rotation")] public CFloat Rotation { get; set; }

		public inkUITransform(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
