using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioLanguageMapItem : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("language")] public audioLanguage Language { get; set; }

		public audioLanguageMapItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
