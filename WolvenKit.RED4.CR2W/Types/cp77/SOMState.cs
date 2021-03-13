using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SOMState : CVariable
	{
		[Ordinal(0)] [RED("depthStencilModeDesc")] public PSODescDepthStencilModeDesc DepthStencilModeDesc { get; set; }
		[Ordinal(1)] [RED("rasterizerModeDesc")] public PSODescRasterizerModeDesc RasterizerModeDesc { get; set; }
		[Ordinal(2)] [RED("blendModeDesc")] public PSODescBlendModeDesc BlendModeDesc { get; set; }
		[Ordinal(3)] [RED("stencilReadMask")] public CUInt8 StencilReadMask { get; set; }
		[Ordinal(4)] [RED("stencilWriteMask")] public CUInt8 StencilWriteMask { get; set; }
		[Ordinal(5)] [RED("stencilRef")] public CUInt8 StencilRef { get; set; }

		public SOMState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
