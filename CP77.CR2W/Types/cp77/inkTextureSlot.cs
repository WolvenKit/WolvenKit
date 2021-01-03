using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkTextureSlot : CVariable
	{
		[Ordinal(0)]  [RED("parts")] public CArray<inkTextureAtlasMapper> Parts { get; set; }
		[Ordinal(1)]  [RED("slices")] public CArray<inkTextureAtlasSlice> Slices { get; set; }
		[Ordinal(2)]  [RED("texture")] public raRef<CBitmapTexture> Texture { get; set; }

		public inkTextureSlot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
