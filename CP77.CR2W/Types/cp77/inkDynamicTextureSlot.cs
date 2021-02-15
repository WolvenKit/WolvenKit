using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkDynamicTextureSlot : CVariable
	{
		[Ordinal(0)] [RED("texture")] public raRef<DynamicTexture> Texture { get; set; }
		[Ordinal(1)] [RED("parts")] public CArray<inkTextureAtlasMapper> Parts { get; set; }

		public inkDynamicTextureSlot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
