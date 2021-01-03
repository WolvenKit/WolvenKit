using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioVisualTagAppearanceMapping : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("mappings")] public CArray<audioVisualTagAppearanceGroup> Mappings { get; set; }

		public audioVisualTagAppearanceMapping(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
