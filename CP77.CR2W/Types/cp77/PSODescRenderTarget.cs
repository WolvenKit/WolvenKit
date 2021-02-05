using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PSODescRenderTarget : CVariable
	{
		[Ordinal(0)]  [RED("blendEnable")] public CBool BlendEnable { get; set; }
		[Ordinal(1)]  [RED("writeMask")] public CEnum<PSODescBlendModeWriteMask> WriteMask { get; set; }
		[Ordinal(2)]  [RED("colorOp")] public CEnum<PSODescBlendModeOp> ColorOp { get; set; }
		[Ordinal(3)]  [RED("alphaOp")] public CEnum<PSODescBlendModeOp> AlphaOp { get; set; }
		[Ordinal(4)]  [RED("destFactor")] public CEnum<PSODescBlendModeFactor> DestFactor { get; set; }
		[Ordinal(5)]  [RED("destAlphaFactor")] public CEnum<PSODescBlendModeFactor> DestAlphaFactor { get; set; }
		[Ordinal(6)]  [RED("srcFactor")] public CEnum<PSODescBlendModeFactor> SrcFactor { get; set; }
		[Ordinal(7)]  [RED("srcAlphaFactor")] public CEnum<PSODescBlendModeFactor> SrcAlphaFactor { get; set; }

		public PSODescRenderTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
