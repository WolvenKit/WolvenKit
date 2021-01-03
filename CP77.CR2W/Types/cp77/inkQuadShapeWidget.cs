using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkQuadShapeWidget : inkBaseShapeWidget
	{
		[Ordinal(0)]  [RED("textureAtlas")] public raRef<inkTextureAtlas> TextureAtlas { get; set; }
		[Ordinal(1)]  [RED("texturePart")] public CName TexturePart { get; set; }
		[Ordinal(2)]  [RED("vertexList")] public CArray<Vector2> VertexList { get; set; }

		public inkQuadShapeWidget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
