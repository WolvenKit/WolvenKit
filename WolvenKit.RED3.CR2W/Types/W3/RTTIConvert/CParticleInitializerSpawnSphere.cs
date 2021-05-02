using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CParticleInitializerSpawnSphere : IParticleInitializer
	{
		[Ordinal(1)] [RED("innerRadius")] 		public CPtr<IEvaluatorFloat> InnerRadius { get; set;}

		[Ordinal(2)] [RED("outerRadius")] 		public CPtr<IEvaluatorFloat> OuterRadius { get; set;}

		[Ordinal(3)] [RED("surfaceOnly")] 		public CBool SurfaceOnly { get; set;}

		[Ordinal(4)] [RED("spawnPositiveX")] 		public CBool SpawnPositiveX { get; set;}

		[Ordinal(5)] [RED("spawnNegativeX")] 		public CBool SpawnNegativeX { get; set;}

		[Ordinal(6)] [RED("spawnPositiveY")] 		public CBool SpawnPositiveY { get; set;}

		[Ordinal(7)] [RED("spawnNegativeY")] 		public CBool SpawnNegativeY { get; set;}

		[Ordinal(8)] [RED("spawnPositiveZ")] 		public CBool SpawnPositiveZ { get; set;}

		[Ordinal(9)] [RED("spawnNegativeZ")] 		public CBool SpawnNegativeZ { get; set;}

		[Ordinal(10)] [RED("velocity")] 		public CBool Velocity { get; set;}

		[Ordinal(11)] [RED("forceScale")] 		public CPtr<IEvaluatorFloat> ForceScale { get; set;}

		public CParticleInitializerSpawnSphere(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CParticleInitializerSpawnSphere(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}