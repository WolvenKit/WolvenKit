using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_TransformConstant : animAnimNode_TransformValue
	{
		[Ordinal(0)]  [RED("pos")] public Vector4 Pos { get; set; }
		[Ordinal(1)]  [RED("rotation")] public Quaternion Rotation { get; set; }
		[Ordinal(2)]  [RED("scale")] public Vector4 Scale { get; set; }

		public animAnimNode_TransformConstant(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
