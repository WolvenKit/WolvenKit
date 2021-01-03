using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class localizationPersistenceLocDataMapEntry : CVariable
	{
		[Ordinal(0)]  [RED("langCode")] public CName LangCode { get; set; }
		[Ordinal(1)]  [RED("onscreensPath")] public raRef<JsonResource> OnscreensPath { get; set; }
		[Ordinal(2)]  [RED("subtitlePath")] public raRef<JsonResource> SubtitlePath { get; set; }

		public localizationPersistenceLocDataMapEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
