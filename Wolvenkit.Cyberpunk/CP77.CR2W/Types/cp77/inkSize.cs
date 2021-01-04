using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkSize : CVariable
	{
		[Ordinal(0)]  [RED("height")] public CFloat Height { get; set; }
		[Ordinal(1)]  [RED("width")] public CFloat Width { get; set; }

		public inkSize(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
