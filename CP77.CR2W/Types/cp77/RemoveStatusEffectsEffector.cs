using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class RemoveStatusEffectsEffector : gameEffector
	{
		[Ordinal(0)]  [RED("effectString")] public CArray<CString> EffectString { get; set; }
		[Ordinal(1)]  [RED("effectTags")] public CArray<CName> EffectTags { get; set; }
		[Ordinal(2)]  [RED("effectTypes")] public CArray<CString> EffectTypes { get; set; }

		public RemoveStatusEffectsEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
