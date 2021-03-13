using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CParticleModificatorVelocityTurbulize : IParticleModificator
	{
		[Ordinal(1)] [RED("scale")] 		public CPtr<IEvaluatorVector> Scale { get; set;}

		[Ordinal(2)] [RED("timelifeLimit")] 		public CPtr<IEvaluatorFloat> TimelifeLimit { get; set;}

		[Ordinal(3)] [RED("noiseInterval")] 		public CFloat NoiseInterval { get; set;}

		[Ordinal(4)] [RED("duration")] 		public CFloat Duration { get; set;}

		public CParticleModificatorVelocityTurbulize(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CParticleModificatorVelocityTurbulize(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}