using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entRenderToTextureFeatures : CVariable
	{
		[Ordinal(0)]  [RED("renderDecals")] public CBool RenderDecals { get; set; }
		[Ordinal(1)]  [RED("renderParticles")] public CBool RenderParticles { get; set; }
		[Ordinal(2)]  [RED("renderForwardNoTXAA")] public CBool RenderForwardNoTXAA { get; set; }
		[Ordinal(3)]  [RED("antiAliasing")] public CBool AntiAliasing { get; set; }
		[Ordinal(4)]  [RED("contactShadows")] public CBool ContactShadows { get; set; }
		[Ordinal(5)]  [RED("localShadows")] public CBool LocalShadows { get; set; }
		[Ordinal(6)]  [RED("allowOcclusionCulling")] public CBool AllowOcclusionCulling { get; set; }

		public entRenderToTextureFeatures(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
