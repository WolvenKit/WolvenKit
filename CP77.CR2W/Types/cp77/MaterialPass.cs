using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class MaterialPass : CVariable
	{
		[Ordinal(0)] [RED("stagePassNameRegular")] public CName StagePassNameRegular { get; set; }
		[Ordinal(1)] [RED("stagePassNameDiscarded")] public CName StagePassNameDiscarded { get; set; }
		[Ordinal(2)] [RED("depthStencilMode")] public PSODescDepthStencilModeDesc DepthStencilMode { get; set; }
		[Ordinal(3)] [RED("rasterizerMode")] public PSODescRasterizerModeDesc RasterizerMode { get; set; }
		[Ordinal(4)] [RED("blendMode")] public PSODescBlendModeDesc BlendMode { get; set; }
		[Ordinal(5)] [RED("stencilReadMask")] public CUInt8 StencilReadMask { get; set; }
		[Ordinal(6)] [RED("stencilWriteMask")] public CUInt8 StencilWriteMask { get; set; }
		[Ordinal(7)] [RED("stencilRef")] public CUInt8 StencilRef { get; set; }
		[Ordinal(8)] [RED("orderIndex")] public CUInt8 OrderIndex { get; set; }
		[Ordinal(9)] [RED("enablePixelShader")] public CBool EnablePixelShader { get; set; }

		public MaterialPass(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
