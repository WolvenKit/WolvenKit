using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioFoleyPlayerAppearanceMappingMetadata : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("fallbackMetadata")] public CName FallbackMetadata { get; set; }
		[Ordinal(1)]  [RED("jacketSettings")] public CArray<audioAppearanceToPlayerMetadata> JacketSettings { get; set; }
		[Ordinal(2)]  [RED("topSettings")] public CArray<audioAppearanceToPlayerMetadata> TopSettings { get; set; }
		[Ordinal(3)]  [RED("bottomSettings")] public CArray<audioAppearanceToPlayerMetadata> BottomSettings { get; set; }
		[Ordinal(4)]  [RED("jewelrySettings")] public CArray<audioAppearanceToPlayerMetadata> JewelrySettings { get; set; }

		public audioFoleyPlayerAppearanceMappingMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
