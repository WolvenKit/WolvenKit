using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioFoleyNPCAppearanceMappingMetadata : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("NPCsPerAdditive")] public CArray<audioVisualTagToNPCMetadata> NPCsPerAdditive { get; set; }
		[Ordinal(1)]  [RED("NPCsPerAppearance")] public CArray<audioAppearanceToNPCMetadata> NPCsPerAppearance { get; set; }
		[Ordinal(2)]  [RED("NPCsPerMainMaterial")] public CArray<audioVisualTagToNPCMetadata> NPCsPerMainMaterial { get; set; }
		[Ordinal(3)]  [RED("fallbackMetadata")] public CName FallbackMetadata { get; set; }

		public audioFoleyNPCAppearanceMappingMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
