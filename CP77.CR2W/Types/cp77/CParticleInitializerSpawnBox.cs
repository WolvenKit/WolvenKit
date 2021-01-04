using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CParticleInitializerSpawnBox : IParticleInitializer
	{
		[Ordinal(0)]  [RED("extents")] public CHandle<IEvaluatorVector> Extents { get; set; }
		[Ordinal(1)]  [RED("surfaceOnly")] public CBool SurfaceOnly { get; set; }
		[Ordinal(2)]  [RED("worldSpace")] public CBool WorldSpace { get; set; }

		public CParticleInitializerSpawnBox(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
