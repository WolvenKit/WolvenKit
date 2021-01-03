using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkDynamicTextureSlot : CVariable
	{
		[Ordinal(0)]  [RED("parts")] public CArray<inkTextureAtlasMapper> Parts { get; set; }
		[Ordinal(1)]  [RED("texture")] public raRef<DynamicTexture> Texture { get; set; }

		public inkDynamicTextureSlot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
