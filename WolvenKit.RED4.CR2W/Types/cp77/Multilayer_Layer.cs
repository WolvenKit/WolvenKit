using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Multilayer_Layer : CVariable
	{
		[Ordinal(0)] [RED("matTile")] public CFloat MatTile { get; set; }
		[Ordinal(1)] [RED("mbTile")] public CFloat MbTile { get; set; }
		[Ordinal(2)] [RED("microblend")] public rRef<CBitmapTexture> Microblend { get; set; }
		[Ordinal(3)] [RED("microblendContrast")] public CFloat MicroblendContrast { get; set; }
		[Ordinal(4)] [RED("microblendNormalStrength")] public CFloat MicroblendNormalStrength { get; set; }
		[Ordinal(5)] [RED("microblendOffsetU")] public CFloat MicroblendOffsetU { get; set; }
		[Ordinal(6)] [RED("microblendOffsetV")] public CFloat MicroblendOffsetV { get; set; }
		[Ordinal(7)] [RED("opacity")] public CFloat Opacity { get; set; }
		[Ordinal(8)] [RED("offsetU")] public CFloat OffsetU { get; set; }
		[Ordinal(9)] [RED("offsetV")] public CFloat OffsetV { get; set; }
		[Ordinal(10)] [RED("material")] public rRef<Multilayer_LayerTemplate> Material { get; set; }
		[Ordinal(11)] [RED("colorScale")] public CName ColorScale { get; set; }
		[Ordinal(12)] [RED("normalStrength")] public CName NormalStrength { get; set; }
		[Ordinal(13)] [RED("roughLevelsIn")] public CName RoughLevelsIn { get; set; }
		[Ordinal(14)] [RED("roughLevelsOut")] public CName RoughLevelsOut { get; set; }
		[Ordinal(15)] [RED("metalLevelsIn")] public CName MetalLevelsIn { get; set; }
		[Ordinal(16)] [RED("metalLevelsOut")] public CName MetalLevelsOut { get; set; }
		[Ordinal(17)] [RED("overrides")] public CName Overrides { get; set; }

		public Multilayer_Layer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
