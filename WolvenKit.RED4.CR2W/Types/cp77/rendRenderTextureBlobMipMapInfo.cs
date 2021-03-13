using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class rendRenderTextureBlobMipMapInfo : CVariable
	{
		[Ordinal(0)] [RED("layout")] public rendRenderTextureBlobMemoryLayout Layout { get; set; }
		[Ordinal(1)] [RED("placement")] public rendRenderTextureBlobPlacement Placement { get; set; }

		public rendRenderTextureBlobMipMapInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
