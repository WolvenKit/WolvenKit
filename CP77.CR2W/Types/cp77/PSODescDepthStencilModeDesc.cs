using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class PSODescDepthStencilModeDesc : CVariable
	{
		[Ordinal(0)]  [RED("depthFunc")] public CEnum<PSODescDepthStencilModeComparisonMode> DepthFunc { get; set; }
		[Ordinal(1)]  [RED("depthTestEnable")] public CBool DepthTestEnable { get; set; }
		[Ordinal(2)]  [RED("depthWriteEnable")] public CBool DepthWriteEnable { get; set; }
		[Ordinal(3)]  [RED("frontFace")] public PSODescStencilFuncDesc FrontFace { get; set; }
		[Ordinal(4)]  [RED("stencilEnable")] public CBool StencilEnable { get; set; }
		[Ordinal(5)]  [RED("stencilReadMask")] public CBool StencilReadMask { get; set; }
		[Ordinal(6)]  [RED("stencilWriteMask")] public CBool StencilWriteMask { get; set; }

		public PSODescDepthStencilModeDesc(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
