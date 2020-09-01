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
		[Ordinal(0)] [RED("activationTimeLimitBonusHeavy")] 		public CFloat ActivationTimeLimitBonusHeavy { get; set;}

		[Ordinal(0)] [RED("activationTimeLimitBonusLight")] 		public CFloat ActivationTimeLimitBonusLight { get; set;}

		[Ordinal(0)] [RED("checkParryChance")] 		public CBool CheckParryChance { get; set;}

		[Ordinal(0)] [RED("interruptTaskToExecuteCounter")] 		public CBool InterruptTaskToExecuteCounter { get; set;}

		[Ordinal(0)] [RED("allowParryOverlap")] 		public CBool AllowParryOverlap { get; set;}

		[Ordinal(0)] [RED("activationTimeLimit")] 		public CFloat ActivationTimeLimit { get; set;}

		[Ordinal(0)] [RED("action")] 		public CName Action { get; set;}

		[Ordinal(0)] [RED("runMain")] 		public CBool RunMain { get; set;}

		[Ordinal(0)] [RED("parryChance")] 		public CFloat ParryChance { get; set;}

		[Ordinal(0)] [RED("counterChance")] 		public CFloat CounterChance { get; set;}

		[Ordinal(0)] [RED("counterMultiplier")] 		public CFloat CounterMultiplier { get; set;}

		[Ordinal(0)] [RED("hitsToCounter")] 		public CInt32 HitsToCounter { get; set;}

		[Ordinal(0)] [RED("swingType")] 		public CInt32 SwingType { get; set;}

		[Ordinal(0)] [RED("swingDir")] 		public CInt32 SwingDir { get; set;}

		public CBTTaskPerformParry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskPerformParry(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}