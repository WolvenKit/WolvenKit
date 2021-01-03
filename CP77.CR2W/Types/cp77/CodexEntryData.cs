using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CodexEntryData : GenericCodexEntryData
	{
		[Ordinal(0)]  [RED("category")] public CInt32 Category { get; set; }
		[Ordinal(1)]  [RED("imageType")] public CEnum<CodexImageType> ImageType { get; set; }

		public CodexEntryData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
