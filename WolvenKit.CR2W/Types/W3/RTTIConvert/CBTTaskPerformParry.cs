using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskPerformParry : CBTTaskPlayAnimationEventDecorator
	{
		[RED("activationTimeLimitBonusHeavy")] 		public CFloat ActivationTimeLimitBonusHeavy { get; set;}

		[RED("activationTimeLimitBonusLight")] 		public CFloat ActivationTimeLimitBonusLight { get; set;}

		[RED("checkParryChance")] 		public CBool CheckParryChance { get; set;}

		[RED("interruptTaskToExecuteCounter")] 		public CBool InterruptTaskToExecuteCounter { get; set;}

		[RED("allowParryOverlap")] 		public CBool AllowParryOverlap { get; set;}

		[RED("activationTimeLimit")] 		public CFloat ActivationTimeLimit { get; set;}

		[RED("action")] 		public CName Action { get; set;}

		[RED("runMain")] 		public CBool RunMain { get; set;}

		[RED("parryChance")] 		public CFloat ParryChance { get; set;}

		[RED("counterChance")] 		public CFloat CounterChance { get; set;}

		[RED("counterMultiplier")] 		public CFloat CounterMultiplier { get; set;}

		[RED("hitsToCounter")] 		public CInt32 HitsToCounter { get; set;}

		[RED("swingType")] 		public CInt32 SwingType { get; set;}

		[RED("swingDir")] 		public CInt32 SwingDir { get; set;}

		public CBTTaskPerformParry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskPerformParry(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}