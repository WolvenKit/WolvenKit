using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkTextureSlot : CVariable
	{
		[Ordinal(0)] [RED("texture")] public raRef<CBitmapTexture> Texture { get; set; }
		[Ordinal(1)] [RED("parts")] public CArray<inkTextureAtlasMapper> Parts { get; set; }
		[Ordinal(2)] [RED("slices")] public CArray<inkTextureAtlasSlice> Slices { get; set; }

		public inkTextureSlot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
