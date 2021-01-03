using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioFoleyPlayerAppearanceMappingMetadata : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("bottomSettings")] public CArray<audioAppearanceToPlayerMetadata> BottomSettings { get; set; }
		[Ordinal(1)]  [RED("fallbackMetadata")] public CName FallbackMetadata { get; set; }
		[Ordinal(2)]  [RED("jacketSettings")] public CArray<audioAppearanceToPlayerMetadata> JacketSettings { get; set; }
		[Ordinal(3)]  [RED("jewelrySettings")] public CArray<audioAppearanceToPlayerMetadata> JewelrySettings { get; set; }
		[Ordinal(4)]  [RED("topSettings")] public CArray<audioAppearanceToPlayerMetadata> TopSettings { get; set; }

		public audioFoleyPlayerAppearanceMappingMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
