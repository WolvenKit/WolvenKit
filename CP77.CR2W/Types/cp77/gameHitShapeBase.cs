using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameHitShapeBase : gameIHitShape
	{
		[Ordinal(0)]  [RED("localTransform")] public CMatrix LocalTransform { get; set; }
		[Ordinal(1)]  [RED("rotation")] public Quaternion Rotation { get; set; }
		[Ordinal(2)]  [RED("translation")] public Vector3 Translation { get; set; }

		public gameHitShapeBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
