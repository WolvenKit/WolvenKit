using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class Vector3 : CVariable
	{
		[Ordinal(0)]  [RED("X")] public CFloat X { get; set; }
		[Ordinal(1)]  [RED("Y")] public CFloat Y { get; set; }
		[Ordinal(2)]  [RED("Z")] public CFloat Z { get; set; }

		public Vector3(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
