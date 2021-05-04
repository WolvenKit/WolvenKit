using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CParticleInitializerVelocity : IParticleInitializer
	{
		[Ordinal(1)] [RED("velocity")] 		public CPtr<IEvaluatorVector> Velocity { get; set;}

		[Ordinal(2)] [RED("worldSpace")] 		public CBool WorldSpace { get; set;}

		public CParticleInitializerVelocity(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}