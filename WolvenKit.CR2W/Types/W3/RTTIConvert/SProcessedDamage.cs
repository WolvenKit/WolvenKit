using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SProcessedDamage : CVariable
	{
		[RED("vitalityDamage")] 		public CFloat VitalityDamage { get; set;}

		[RED("essenceDamage")] 		public CFloat EssenceDamage { get; set;}

		[RED("moraleDamage")] 		public CFloat MoraleDamage { get; set;}

		[RED("staminaDamage")] 		public CFloat StaminaDamage { get; set;}

		public SProcessedDamage(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SProcessedDamage(cr2w);

	}
}