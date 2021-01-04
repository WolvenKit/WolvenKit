using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CParticleInitializerSpawnSphere : IParticleInitializer
	{
		[Ordinal(0)]  [RED("forceScale")] public CHandle<IEvaluatorFloat> ForceScale { get; set; }
		[Ordinal(1)]  [RED("innerRadius")] public CHandle<IEvaluatorFloat> InnerRadius { get; set; }
		[Ordinal(2)]  [RED("outerRadius")] public CHandle<IEvaluatorFloat> OuterRadius { get; set; }
		[Ordinal(3)]  [RED("spawnNegativeX")] public CBool SpawnNegativeX { get; set; }
		[Ordinal(4)]  [RED("spawnNegativeY")] public CBool SpawnNegativeY { get; set; }
		[Ordinal(5)]  [RED("spawnNegativeZ")] public CBool SpawnNegativeZ { get; set; }
		[Ordinal(6)]  [RED("spawnPositiveX")] public CBool SpawnPositiveX { get; set; }
		[Ordinal(7)]  [RED("spawnPositiveY")] public CBool SpawnPositiveY { get; set; }
		[Ordinal(8)]  [RED("spawnPositiveZ")] public CBool SpawnPositiveZ { get; set; }
		[Ordinal(9)]  [RED("surfaceOnly")] public CBool SurfaceOnly { get; set; }
		[Ordinal(10)]  [RED("velocity")] public CBool Velocity { get; set; }
		[Ordinal(11)]  [RED("worldSpace")] public CBool WorldSpace { get; set; }

		public CParticleInitializerSpawnSphere(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
