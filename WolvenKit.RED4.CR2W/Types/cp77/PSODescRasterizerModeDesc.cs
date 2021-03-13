using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PSODescRasterizerModeDesc : CVariable
	{
		[Ordinal(0)] [RED("wireframe")] public CBool Wireframe { get; set; }
		[Ordinal(1)] [RED("frontWinding")] public CEnum<PSODescRasterizerModeFrontFaceWinding> FrontWinding { get; set; }
		[Ordinal(2)] [RED("cullMode")] public CEnum<PSODescRasterizerModeCullMode> CullMode { get; set; }
		[Ordinal(3)] [RED("allowMSAA")] public CBool AllowMSAA { get; set; }
		[Ordinal(4)] [RED("conservativeRasterization")] public CBool ConservativeRasterization { get; set; }
		[Ordinal(5)] [RED("offsetMode")] public CEnum<PSODescRasterizerModeOffsetMode> OffsetMode { get; set; }
		[Ordinal(6)] [RED("scissors")] public CBool Scissors { get; set; }
		[Ordinal(7)] [RED("valid")] public CBool Valid { get; set; }

		public PSODescRasterizerModeDesc(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
