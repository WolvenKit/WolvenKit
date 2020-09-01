using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CParticleInitializerSpawnCircle : IParticleInitializer
	{
		[Ordinal(1)] [RED("innerRadius")] 		public CPtr<IEvaluatorFloat> InnerRadius { get; set;}

		[Ordinal(2)] [RED("outerRadius")] 		public CPtr<IEvaluatorFloat> OuterRadius { get; set;}

		[Ordinal(3)] [RED("surfaceOnly")] 		public CBool SurfaceOnly { get; set;}

		[Ordinal(4)] [RED("worldSpace")] 		public CBool WorldSpace { get; set;}

		[Ordinal(5)] [RED("spawnToLocal")] 		public CMatrix SpawnToLocal { get; set;}

		public CParticleInitializerSpawnCircle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CParticleInitializerSpawnCircle(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}