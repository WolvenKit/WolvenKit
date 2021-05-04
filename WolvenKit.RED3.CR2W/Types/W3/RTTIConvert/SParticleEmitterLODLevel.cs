using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SParticleEmitterLODLevel : CVariable
	{
		[Ordinal(1)] [RED("emitterDurationSettings")] 		public EmitterDurationSettings EmitterDurationSettings { get; set;}

		[Ordinal(2)] [RED("emitterDelaySettings")] 		public EmitterDelaySettings EmitterDelaySettings { get; set;}

		[Ordinal(3)] [RED("burstList", 2,0)] 		public CArray<ParticleBurst> BurstList { get; set;}

		[Ordinal(4)] [RED("birthRate")] 		public CPtr<IEvaluatorFloat> BirthRate { get; set;}

		[Ordinal(5)] [RED("sortBackToFront")] 		public CBool SortBackToFront { get; set;}

		[Ordinal(6)] [RED("isEnabled")] 		public CBool IsEnabled { get; set;}

		public SParticleEmitterLODLevel(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}