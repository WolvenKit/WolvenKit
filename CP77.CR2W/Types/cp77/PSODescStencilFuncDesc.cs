using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class PSODescStencilFuncDesc : CVariable
	{
		[Ordinal(0)]  [RED("stencilFunc")] public CEnum<PSODescDepthStencilModeComparisonMode> StencilFunc { get; set; }
		[Ordinal(1)]  [RED("stencilPassOp")] public CEnum<PSODescDepthStencilModeStencilOpMode> StencilPassOp { get; set; }

		public PSODescStencilFuncDesc(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
