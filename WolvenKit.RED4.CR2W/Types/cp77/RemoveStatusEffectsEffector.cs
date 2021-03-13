using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RemoveStatusEffectsEffector : gameEffector
	{
		[Ordinal(0)] [RED("effectTypes")] public CArray<CString> EffectTypes { get; set; }
		[Ordinal(1)] [RED("effectString")] public CArray<CString> EffectString { get; set; }
		[Ordinal(2)] [RED("effectTags")] public CArray<CName> EffectTags { get; set; }

		public RemoveStatusEffectsEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
