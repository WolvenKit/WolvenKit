using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldDistantGINode : worldNode
	{
		[Ordinal(4)] [RED("dataAlbedo")] public raRef<CBitmapTexture> DataAlbedo { get; set; }
		[Ordinal(5)] [RED("dataNormal")] public raRef<CBitmapTexture> DataNormal { get; set; }
		[Ordinal(6)] [RED("dataHeight")] public raRef<CBitmapTexture> DataHeight { get; set; }
		[Ordinal(7)] [RED("sectorSpan")] public Vector4 SectorSpan { get; set; }

		public worldDistantGINode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
