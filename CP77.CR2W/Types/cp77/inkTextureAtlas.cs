using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkTextureAtlas : CResource
	{
		[Ordinal(0)]  [RED("activeTexture")] public CEnum<inkTextureType> ActiveTexture { get; set; }
		[Ordinal(1)]  [RED("dynamicTexture")] public raRef<DynamicTexture> DynamicTexture { get; set; }
		[Ordinal(2)]  [RED("dynamicTextureSlot")] public inkDynamicTextureSlot DynamicTextureSlot { get; set; }
		[Ordinal(3)]  [RED("isSingleTextureMode")] public CBool IsSingleTextureMode { get; set; }
		[Ordinal(4)]  [RED("parts")] public CArray<inkTextureAtlasMapper> Parts { get; set; }
		[Ordinal(5)]  [RED("slices")] public CArray<inkTextureAtlasSlice> Slices { get; set; }
		[Ordinal(6)]  [RED("slots")] public [3]inkTextureSlot Slots { get; set; }
		[Ordinal(7)]  [RED("texture")] public raRef<CBitmapTexture> Texture { get; set; }
		[Ordinal(8)]  [RED("textureResolution")] public CEnum<inkETextureResolution> TextureResolution { get; set; }

		public inkTextureAtlas(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
