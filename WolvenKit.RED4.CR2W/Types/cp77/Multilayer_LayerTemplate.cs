using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Multilayer_LayerTemplate : CResource
	{
		[Ordinal(1)] [RED("overrides")] public Multilayer_LayerTemplateOverrides Overrides { get; set; }
		[Ordinal(2)] [RED("defaultOverrides")] public Multilayer_LayerOverrideSelection DefaultOverrides { get; set; }
		[Ordinal(3)] [RED("colorTexture")] public rRef<CBitmapTexture> ColorTexture { get; set; }
		[Ordinal(4)] [RED("normalTexture")] public rRef<CBitmapTexture> NormalTexture { get; set; }
		[Ordinal(5)] [RED("roughnessTexture")] public rRef<CBitmapTexture> RoughnessTexture { get; set; }
		[Ordinal(6)] [RED("metalnessTexture")] public rRef<CBitmapTexture> MetalnessTexture { get; set; }
		[Ordinal(7)] [RED("tilingMultiplier")] public CFloat TilingMultiplier { get; set; }
		[Ordinal(8)] [RED("colorMaskLevelsIn", 2)] public CArrayFixedSize<CFloat> ColorMaskLevelsIn { get; set; }
		[Ordinal(9)] [RED("colorMaskLevelsOut", 2)] public CArrayFixedSize<CFloat> ColorMaskLevelsOut { get; set; }

		public Multilayer_LayerTemplate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
