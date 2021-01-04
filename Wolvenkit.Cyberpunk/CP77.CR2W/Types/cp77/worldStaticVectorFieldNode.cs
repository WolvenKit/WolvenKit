using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldStaticVectorFieldNode : worldNode
	{
		[Ordinal(0)]  [RED("autoHideDistance")] public CFloat AutoHideDistance { get; set; }
		[Ordinal(1)]  [RED("direction")] public Vector3 Direction { get; set; }

		public worldStaticVectorFieldNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
