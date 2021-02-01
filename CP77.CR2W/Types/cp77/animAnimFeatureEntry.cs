using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimFeatureEntry : CVariable
	{
		[Ordinal(0)]  [RED("className")] public CName ClassName { get; set; }
		[Ordinal(1)]  [RED("forceAllocate")] public CBool ForceAllocate { get; set; }
		[Ordinal(2)]  [RED("name")] public CName Name { get; set; }
		
        [Ordinal(999)]  [RED("debugEnabled")] public CBool debugEnabled { get; set; }

		public animAnimFeatureEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
