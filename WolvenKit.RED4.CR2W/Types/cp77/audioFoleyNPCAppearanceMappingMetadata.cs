using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioFoleyNPCAppearanceMappingMetadata : audioAudioMetadata
	{
		[Ordinal(1)] [RED("fallbackMetadata")] public CName FallbackMetadata { get; set; }
		[Ordinal(2)] [RED("NPCsPerAppearance")] public CArray<audioAppearanceToNPCMetadata> NPCsPerAppearance { get; set; }
		[Ordinal(3)] [RED("NPCsPerMainMaterial")] public CArray<audioVisualTagToNPCMetadata> NPCsPerMainMaterial { get; set; }
		[Ordinal(4)] [RED("NPCsPerAdditive")] public CArray<audioVisualTagToNPCMetadata> NPCsPerAdditive { get; set; }

		public audioFoleyNPCAppearanceMappingMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
