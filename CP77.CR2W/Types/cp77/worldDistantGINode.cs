using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldDistantGINode : worldNode
	{
		[Ordinal(0)]  [RED("dataAlbedo")] public raRef<CBitmapTexture> DataAlbedo { get; set; }
		[Ordinal(1)]  [RED("dataHeight")] public raRef<CBitmapTexture> DataHeight { get; set; }
		[Ordinal(2)]  [RED("dataNormal")] public raRef<CBitmapTexture> DataNormal { get; set; }
		[Ordinal(3)]  [RED("sectorSpan")] public Vector4 SectorSpan { get; set; }

		public worldDistantGINode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
