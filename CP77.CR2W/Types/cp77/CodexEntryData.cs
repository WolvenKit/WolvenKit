using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CodexEntryData : GenericCodexEntryData
	{
		[Ordinal(10)] [RED("category")] public CInt32 Category { get; set; }
		[Ordinal(11)] [RED("imageType")] public CEnum<CodexImageType> ImageType { get; set; }

		public CodexEntryData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
