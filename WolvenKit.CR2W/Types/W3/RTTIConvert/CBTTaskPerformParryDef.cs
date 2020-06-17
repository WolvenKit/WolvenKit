using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskPerformParryDef : CBTTaskPlayAnimationEventDecoratorDef
	{
		[RED("activationTimeLimitBonusHeavy")] 		public CBehTreeValFloat ActivationTimeLimitBonusHeavy { get; set;}

		[RED("activationTimeLimitBonusLight")] 		public CBehTreeValFloat ActivationTimeLimitBonusLight { get; set;}

		[RED("checkParryChance")] 		public CBool CheckParryChance { get; set;}

		[RED("interruptTaskToExecuteCounter")] 		public CBool InterruptTaskToExecuteCounter { get; set;}

		[RED("allowParryOverlap")] 		public CBool AllowParryOverlap { get; set;}

		public CBTTaskPerformParryDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBTTaskPerformParryDef(cr2w);

	}
}