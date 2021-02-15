using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CParticleInitializerSpawnSphere : IParticleInitializer
	{
		[Ordinal(4)] [RED("innerRadius")] public CHandle<IEvaluatorFloat> InnerRadius { get; set; }
		[Ordinal(5)] [RED("outerRadius")] public CHandle<IEvaluatorFloat> OuterRadius { get; set; }
		[Ordinal(6)] [RED("surfaceOnly")] public CBool SurfaceOnly { get; set; }
		[Ordinal(7)] [RED("spawnPositiveX")] public CBool SpawnPositiveX { get; set; }
		[Ordinal(8)] [RED("spawnNegativeX")] public CBool SpawnNegativeX { get; set; }
		[Ordinal(9)] [RED("spawnPositiveY")] public CBool SpawnPositiveY { get; set; }
		[Ordinal(10)] [RED("spawnNegativeY")] public CBool SpawnNegativeY { get; set; }
		[Ordinal(11)] [RED("spawnPositiveZ")] public CBool SpawnPositiveZ { get; set; }
		[Ordinal(12)] [RED("spawnNegativeZ")] public CBool SpawnNegativeZ { get; set; }
		[Ordinal(13)] [RED("velocity")] public CBool Velocity { get; set; }
		[Ordinal(14)] [RED("worldSpace")] public CBool WorldSpace { get; set; }
		[Ordinal(15)] [RED("forceScale")] public CHandle<IEvaluatorFloat> ForceScale { get; set; }

		public CParticleInitializerSpawnSphere(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
