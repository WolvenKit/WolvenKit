using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskPerformParry : CBTTaskPlayAnimationEventDecorator
	{
		[Ordinal(1)] [RED("activationTimeLimitBonusHeavy")] 		public CFloat ActivationTimeLimitBonusHeavy { get; set;}

		[Ordinal(2)] [RED("activationTimeLimitBonusLight")] 		public CFloat ActivationTimeLimitBonusLight { get; set;}

		[Ordinal(3)] [RED("checkParryChance")] 		public CBool CheckParryChance { get; set;}

		[Ordinal(4)] [RED("interruptTaskToExecuteCounter")] 		public CBool InterruptTaskToExecuteCounter { get; set;}

		[Ordinal(5)] [RED("allowParryOverlap")] 		public CBool AllowParryOverlap { get; set;}

		[Ordinal(6)] [RED("activationTimeLimit")] 		public CFloat ActivationTimeLimit { get; set;}

		[Ordinal(7)] [RED("action")] 		public CName Action { get; set;}

		[Ordinal(8)] [RED("runMain")] 		public CBool RunMain { get; set;}

		[Ordinal(9)] [RED("parryChance")] 		public CFloat ParryChance { get; set;}

		[Ordinal(10)] [RED("counterChance")] 		public CFloat CounterChance { get; set;}

		[Ordinal(11)] [RED("counterMultiplier")] 		public CFloat CounterMultiplier { get; set;}

		[Ordinal(12)] [RED("hitsToCounter")] 		public CInt32 HitsToCounter { get; set;}

		[Ordinal(13)] [RED("swingType")] 		public CInt32 SwingType { get; set;}

		[Ordinal(14)] [RED("swingDir")] 		public CInt32 SwingDir { get; set;}

		public CBTTaskPerformParry(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskPerformParry(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}