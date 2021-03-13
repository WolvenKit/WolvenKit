using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PSODescStencilFuncDesc : CVariable
	{
		[Ordinal(0)] [RED("stencilPassOp")] public CEnum<PSODescDepthStencilModeStencilOpMode> StencilPassOp { get; set; }
		[Ordinal(1)] [RED("stencilFunc")] public CEnum<PSODescDepthStencilModeComparisonMode> StencilFunc { get; set; }

		public PSODescStencilFuncDesc(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
