using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class localizationPersistenceLocDataMapEntry : CVariable
	{
		[Ordinal(0)] [RED("langCode")] public CName LangCode { get; set; }
		[Ordinal(1)] [RED("onscreensPath")] public raRef<JsonResource> OnscreensPath { get; set; }
		[Ordinal(2)] [RED("subtitlePath")] public raRef<JsonResource> SubtitlePath { get; set; }

		public localizationPersistenceLocDataMapEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
