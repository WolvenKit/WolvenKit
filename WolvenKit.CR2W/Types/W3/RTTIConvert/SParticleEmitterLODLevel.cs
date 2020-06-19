using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SParticleEmitterLODLevel : CVariable
	{
		[RED("emitterDurationSettings")] 		public EmitterDurationSettings EmitterDurationSettings { get; set;}

		[RED("emitterDelaySettings")] 		public EmitterDelaySettings EmitterDelaySettings { get; set;}

		[RED("burstList", 2,0)] 		public CArray<ParticleBurst> BurstList { get; set;}

		[RED("birthRate")] 		public CPtr<IEvaluatorFloat> BirthRate { get; set;}

		[RED("sortBackToFront")] 		public CBool SortBackToFront { get; set;}

		[RED("isEnabled")] 		public CBool IsEnabled { get; set;}

		public SParticleEmitterLODLevel(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SParticleEmitterLODLevel(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}