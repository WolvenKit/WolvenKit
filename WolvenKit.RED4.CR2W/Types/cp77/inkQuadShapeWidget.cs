using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkQuadShapeWidget : inkBaseShapeWidget
	{
		[Ordinal(20)] [RED("textureAtlas")] public raRef<inkTextureAtlas> TextureAtlas { get; set; }
		[Ordinal(21)] [RED("texturePart")] public CName TexturePart { get; set; }
		[Ordinal(22)] [RED("vertexList")] public CArray<Vector2> VertexList { get; set; }

		public inkQuadShapeWidget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
