using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CBitmapTexture : ITexture
	{
		[Ordinal(0)]  [RED("width")] public CUInt32 Width { get; set; }
		[Ordinal(1)]  [RED("height")] public CUInt32 Height { get; set; }
		[Ordinal(2)]  [RED("depth")] public CUInt32 Depth { get; set; }
		[Ordinal(3)]  [RED("setup")] public STextureGroupSetup Setup { get; set; }
		[Ordinal(4)]  [RED("histBiasMulCoef")] public Vector3 HistBiasMulCoef { get; set; }
		[Ordinal(5)]  [RED("histBiasAddCoef")] public Vector3 HistBiasAddCoef { get; set; }
		[Ordinal(6)]  [RED("renderResourceBlob")] public CHandle<IRenderResourceBlob> RenderResourceBlob { get; set; }
		[Ordinal(7)]  [RED("renderTextureResource")] public rendRenderTextureResource RenderTextureResource { get; set; }

		public CBitmapTexture(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
