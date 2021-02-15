using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class vgVectorGraphicShape_PolyLine : vgBaseVectorGraphicShape
	{
		[Ordinal(2)] [RED("ints")] public CArray<Vector2> Ints { get; set; }
		[Ordinal(3)] [RED("roke")] public CFloat Roke { get; set; }

		public vgVectorGraphicShape_PolyLine(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
