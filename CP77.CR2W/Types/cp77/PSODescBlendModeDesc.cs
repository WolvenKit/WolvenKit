using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PSODescBlendModeDesc : CVariable
	{
		[Ordinal(0)] [RED("numTargets")] public CUInt8 NumTargets { get; set; }
		[Ordinal(1)] [RED("independent")] public CBool Independent { get; set; }
		[Ordinal(2)] [RED("alphaToCoverage")] public CBool AlphaToCoverage { get; set; }
		[Ordinal(3)] [RED("renderTarget", 8)] public CArrayFixedSize<PSODescRenderTarget> RenderTarget { get; set; }

		public PSODescBlendModeDesc(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
