using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioVoiceTagAppearanceMapping : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("mappings")] public CArray<audioVoiceTagAppearanceGroup> Mappings { get; set; }

		public audioVoiceTagAppearanceMapping(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
