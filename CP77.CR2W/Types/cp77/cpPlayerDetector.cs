using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class cpPlayerDetector : gameObject
	{
		[Ordinal(40)] [RED("range")] public CFloat Range { get; set; }

		public cpPlayerDetector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
