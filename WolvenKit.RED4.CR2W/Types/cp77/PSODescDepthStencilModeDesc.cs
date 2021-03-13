using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PSODescDepthStencilModeDesc : CVariable
	{
		[Ordinal(0)] [RED("depthTestEnable")] public CBool DepthTestEnable { get; set; }
		[Ordinal(1)] [RED("depthWriteEnable")] public CBool DepthWriteEnable { get; set; }
		[Ordinal(2)] [RED("depthFunc")] public CEnum<PSODescDepthStencilModeComparisonMode> DepthFunc { get; set; }
		[Ordinal(3)] [RED("stencilEnable")] public CBool StencilEnable { get; set; }
		[Ordinal(4)] [RED("stencilReadMask")] public CBool StencilReadMask { get; set; }
		[Ordinal(5)] [RED("stencilWriteMask")] public CBool StencilWriteMask { get; set; }
		[Ordinal(6)] [RED("frontFace")] public PSODescStencilFuncDesc FrontFace { get; set; }

		public PSODescDepthStencilModeDesc(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
