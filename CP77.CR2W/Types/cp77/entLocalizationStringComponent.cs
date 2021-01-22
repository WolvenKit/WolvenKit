using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entLocalizationStringComponent : entIComponent
	{
		[Ordinal(0)]  [RED("Strings")] public CArray<entLocalizationStringMapEntry> Strings { get; set; }

		public entLocalizationStringComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
