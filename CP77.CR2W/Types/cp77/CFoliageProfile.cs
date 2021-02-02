using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CFoliageProfile : CResource
	{
		[Ordinal(0)]  [RED("cutoffAlphaMinMip")] public CFloat CutoffAlphaMinMip { get; set; }
		[Ordinal(1)]  [RED("cutoffAlphaMaxMip")] public CFloat CutoffAlphaMaxMip { get; set; }
		[Ordinal(2)]  [RED("billboardCutoffAlpha")] public CFloat BillboardCutoffAlpha { get; set; }
		[Ordinal(3)]  [RED("aoScale")] public CFloat AoScale { get; set; }
		[Ordinal(4)]  [RED("terrainBlendScale")] public CFloat TerrainBlendScale { get; set; }
		[Ordinal(5)]  [RED("terrainBlendBias")] public CFloat TerrainBlendBias { get; set; }
		[Ordinal(6)]  [RED("billboardDepthScale")] public CFloat BillboardDepthScale { get; set; }
		[Ordinal(7)]  [RED("preserveOriginalColor")] public CFloat PreserveOriginalColor { get; set; }
		[Ordinal(8)]  [RED("billboardRoughnessBias")] public CFloat BillboardRoughnessBias { get; set; }
		[Ordinal(9)]  [RED("colorGradient")] public rRef<CGradient> ColorGradient { get; set; }
		[Ordinal(10)]  [RED("colorGradientWeight")] public CFloat ColorGradientWeight { get; set; }
		[Ordinal(11)]  [RED("colorGradientDarkenWeight")] public CFloat ColorGradientDarkenWeight { get; set; }

		public CFoliageProfile(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
