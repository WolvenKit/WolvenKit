using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkUITransform : CVariable
	{
		[Ordinal(0)]  [RED("rotation")] public CFloat Rotation { get; set; }
		[Ordinal(1)]  [RED("scale")] public Vector2 Scale { get; set; }
		[Ordinal(2)]  [RED("shear")] public Vector2 Shear { get; set; }
		[Ordinal(3)]  [RED("translation")] public Vector2 Translation { get; set; }

		public inkUITransform(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
