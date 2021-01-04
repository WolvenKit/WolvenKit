using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class rendRenderParticleBlobHeader : CVariable
	{
		[Ordinal(0)]  [RED("emitterInfo")] public rendRenderParticleBlobEmitterInfo EmitterInfo { get; set; }
		[Ordinal(1)]  [RED("version")] public CUInt32 Version { get; set; }

		public rendRenderParticleBlobHeader(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
