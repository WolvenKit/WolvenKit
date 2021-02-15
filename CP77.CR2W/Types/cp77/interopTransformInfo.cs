using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class interopTransformInfo : CVariable
	{
		[Ordinal(0)] [RED("translation")] public Vector3 Translation { get; set; }
		[Ordinal(1)] [RED("rotation")] public EulerAngles Rotation { get; set; }

		public interopTransformInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
