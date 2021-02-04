using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CParticleInitializerSpawnCircle : IParticleInitializer
	{
		[Ordinal(0)]  [RED("innerRadius")] public CHandle<IEvaluatorFloat> InnerRadius { get; set; }
		[Ordinal(1)]  [RED("outerRadius")] public CHandle<IEvaluatorFloat> OuterRadius { get; set; }
		[Ordinal(2)]  [RED("surfaceOnly")] public CBool SurfaceOnly { get; set; }
		[Ordinal(3)]  [RED("worldSpace")] public CBool WorldSpace { get; set; }
		[Ordinal(4)]  [RED("spawnToLocal")] public CMatrix SpawnToLocal { get; set; }

		public CParticleInitializerSpawnCircle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
