using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkOnscreenVOData : CVariable
	{
		[Ordinal(0)]  [RED("text")] public CRUID Text { get; set; }

		public inkOnscreenVOData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
