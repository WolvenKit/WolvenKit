using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class rendRenderTextureBlobPlacement : CVariable
	{
		[Ordinal(0)] [RED("offset")] public CUInt32 Offset { get; set; }
		[Ordinal(1)] [RED("size")] public CUInt32 Size { get; set; }

		public rendRenderTextureBlobPlacement(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
