using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class Multilayer_LayerTemplate : CResource
	{
		[Ordinal(0)]  [RED("colorMaskLevelsIn", 2)] public CArrayFixedSize<CFloat> ColorMaskLevelsIn { get; set; }
		[Ordinal(1)]  [RED("colorMaskLevelsOut", 2)] public CArrayFixedSize<CFloat> ColorMaskLevelsOut { get; set; }
		[Ordinal(2)]  [RED("colorTexture")] public rRef<CBitmapTexture> ColorTexture { get; set; }
		[Ordinal(3)]  [RED("defaultOverrides")] public Multilayer_LayerOverrideSelection DefaultOverrides { get; set; }
		[Ordinal(4)]  [RED("metalnessTexture")] public rRef<CBitmapTexture> MetalnessTexture { get; set; }
		[Ordinal(5)]  [RED("normalTexture")] public rRef<CBitmapTexture> NormalTexture { get; set; }
		[Ordinal(6)]  [RED("overrides")] public Multilayer_LayerTemplateOverrides Overrides { get; set; }
		[Ordinal(7)]  [RED("roughnessTexture")] public rRef<CBitmapTexture> RoughnessTexture { get; set; }
		[Ordinal(8)]  [RED("tilingMultiplier")] public CFloat TilingMultiplier { get; set; }

		public Multilayer_LayerTemplate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
