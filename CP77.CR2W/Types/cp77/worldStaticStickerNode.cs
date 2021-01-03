using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldStaticStickerNode : worldNode
	{
		[Ordinal(0)]  [RED("alignSpritesHorizontally")] public CBool AlignSpritesHorizontally { get; set; }
		[Ordinal(1)]  [RED("backgroundColor")] public CColor BackgroundColor { get; set; }
		[Ordinal(2)]  [RED("labels")] public CArray<CString> Labels { get; set; }
		[Ordinal(3)]  [RED("scale")] public CFloat Scale { get; set; }
		[Ordinal(4)]  [RED("showBackground")] public CBool ShowBackground { get; set; }
		[Ordinal(5)]  [RED("spriteSize")] public CInt32 SpriteSize { get; set; }
		[Ordinal(6)]  [RED("sprites")] public CArray<raRef<CBitmapTexture>> Sprites { get; set; }
		[Ordinal(7)]  [RED("textColor")] public CColor TextColor { get; set; }
		[Ordinal(8)]  [RED("visibilityDistance")] public CFloat VisibilityDistance { get; set; }

		public worldStaticStickerNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
