using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MaterialLayerDef : CVariable
	{
		[Ordinal(0)] [RED("name")] public CName Name { get; set; }
		[Ordinal(1)] [RED("size")] public CUInt32 Size { get; set; }
		[Ordinal(2)] [RED("colorPalette")] public CArray<CColor> ColorPalette { get; set; }
		[Ordinal(3)] [RED("material")] public rRef<CMaterialInstance> Material { get; set; }

		public MaterialLayerDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
