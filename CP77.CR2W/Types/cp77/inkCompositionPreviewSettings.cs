using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkCompositionPreviewSettings : ISerializable
	{
		[Ordinal(0)]  [RED("previewResolution")] public CEnum<inkETextureResolution> PreviewResolution { get; set; }
		[Ordinal(1)]  [RED("sourceState")] public CName SourceState { get; set; }
		[Ordinal(2)]  [RED("targetState")] public CName TargetState { get; set; }
		[Ordinal(3)]  [RED("texturePart")] public CName TexturePart { get; set; }
		[Ordinal(4)]  [RED("gameFrameTexture")] public raRef<CBitmapTexture> GameFrameTexture { get; set; }
		[Ordinal(5)]  [RED("textureAtlas")] public raRef<inkTextureAtlas> TextureAtlas { get; set; }

		public inkCompositionPreviewSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
