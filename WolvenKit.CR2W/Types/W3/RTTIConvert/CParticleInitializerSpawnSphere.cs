using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CParticleInitializerSpawnSphere : IParticleInitializer
	{
		[RED("innerRadius")] 		public CPtr<IEvaluatorFloat> InnerRadius { get; set;}

		[RED("outerRadius")] 		public CPtr<IEvaluatorFloat> OuterRadius { get; set;}

		[RED("surfaceOnly")] 		public CBool SurfaceOnly { get; set;}

		[RED("spawnPositiveX")] 		public CBool SpawnPositiveX { get; set;}

		[RED("spawnNegativeX")] 		public CBool SpawnNegativeX { get; set;}

		[RED("spawnPositiveY")] 		public CBool SpawnPositiveY { get; set;}

		[RED("spawnNegativeY")] 		public CBool SpawnNegativeY { get; set;}

		[RED("spawnPositiveZ")] 		public CBool SpawnPositiveZ { get; set;}

		[RED("spawnNegativeZ")] 		public CBool SpawnNegativeZ { get; set;}

		[RED("velocity")] 		public CBool Velocity { get; set;}

		[RED("forceScale")] 		public CPtr<IEvaluatorFloat> ForceScale { get; set;}

		public CParticleInitializerSpawnSphere(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CParticleInitializerSpawnSphere(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}