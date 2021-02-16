using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CMaterialLayerLibrary : CResource
	{
		[Ordinal(1)] [RED("uvTiling")] public CFloat UvTiling { get; set; }
		[Ordinal(2)] [RED("mbTiling")] public CFloat MbTiling { get; set; }
		[Ordinal(3)] [RED("microblendContrast")] public CFloat MicroblendContrast { get; set; }
		[Ordinal(4)] [RED("paletteColorIndex")] public CUInt32 PaletteColorIndex { get; set; }
		[Ordinal(5)] [RED("layers")] public CArray<MaterialLayerDef> Layers { get; set; }
		[Ordinal(6)] [RED("microblends")] public CArray<MicroblendDef> Microblends { get; set; }

		public CMaterialLayerLibrary(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
