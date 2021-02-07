using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class localizationPersistenceSubtitleEntry : CVariable
	{
		[Ordinal(0)]  [RED("stringId")] public CRUID StringId { get; set; }
		[Ordinal(1)]  [RED("femaleVariant")] public CString FemaleVariant { get; set; }
		[Ordinal(2)]  [RED("maleVariant")] public CString MaleVariant { get; set; }

		public localizationPersistenceSubtitleEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
