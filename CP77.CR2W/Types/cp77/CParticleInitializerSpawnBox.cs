using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CParticleInitializerSpawnBox : IParticleInitializer
	{
		[Ordinal(4)] [RED("extents")] public CHandle<IEvaluatorVector> Extents { get; set; }
		[Ordinal(5)] [RED("worldSpace")] public CBool WorldSpace { get; set; }
		[Ordinal(6)] [RED("surfaceOnly")] public CBool SurfaceOnly { get; set; }

		public CParticleInitializerSpawnBox(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
