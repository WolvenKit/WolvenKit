using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioCombatVoTriggerVariationsMapItem : CVariable
	{
		[Ordinal(0)]  [RED("name")] public CName Name { get; set; }
		[Ordinal(1)]  [RED("numberOfVariations")] public CInt32 NumberOfVariations { get; set; }
		[Ordinal(2)]  [RED("shuffle")] public CBool Shuffle { get; set; }

		public audioCombatVoTriggerVariationsMapItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
