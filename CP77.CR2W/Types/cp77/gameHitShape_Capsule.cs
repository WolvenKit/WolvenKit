using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameHitShape_Capsule : gameHitShapeBase
	{
		[Ordinal(0)]  [RED("radius")] public CFloat Radius { get; set; }
		[Ordinal(1)]  [RED("height")] public CFloat Height { get; set; }

		public gameHitShape_Capsule(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
