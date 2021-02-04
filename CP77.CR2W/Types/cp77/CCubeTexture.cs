using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CCubeTexture : ITexture
	{
		[Ordinal(0)]  [RED("setup")] public STextureGroupSetup Setup { get; set; }
		[Ordinal(1)]  [RED("size")] public CUInt32 Size { get; set; }
		[Ordinal(2)]  [RED("renderResourceBlob")] public CHandle<IRenderResourceBlob> RenderResourceBlob { get; set; }
		[Ordinal(3)]  [RED("renderTextureResource")] public rendRenderTextureResource RenderTextureResource { get; set; }

		public CCubeTexture(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
