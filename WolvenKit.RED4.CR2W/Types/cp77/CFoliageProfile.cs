using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CFoliageProfile : CResource
	{
		[Ordinal(1)] [RED("cutoffAlphaMinMip")] public CFloat CutoffAlphaMinMip { get; set; }
		[Ordinal(2)] [RED("cutoffAlphaMaxMip")] public CFloat CutoffAlphaMaxMip { get; set; }
		[Ordinal(3)] [RED("billboardCutoffAlpha")] public CFloat BillboardCutoffAlpha { get; set; }
		[Ordinal(4)] [RED("aoScale")] public CFloat AoScale { get; set; }
		[Ordinal(5)] [RED("terrainBlendScale")] public CFloat TerrainBlendScale { get; set; }
		[Ordinal(6)] [RED("terrainBlendBias")] public CFloat TerrainBlendBias { get; set; }
		[Ordinal(7)] [RED("billboardDepthScale")] public CFloat BillboardDepthScale { get; set; }
		[Ordinal(8)] [RED("billboardRoughnessBias")] public CFloat BillboardRoughnessBias { get; set; }
		[Ordinal(9)] [RED("colorGradient")] public rRef<CGradient> ColorGradient { get; set; }
		[Ordinal(10)] [RED("colorGradientWeight")] public CFloat ColorGradientWeight { get; set; }
		[Ordinal(11)] [RED("colorGradientDarkenWeight")] public CFloat ColorGradientDarkenWeight { get; set; }
		[Ordinal(12)] [RED("preserveOriginalColor")] public CFloat PreserveOriginalColor { get; set; }

		public CFoliageProfile(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
