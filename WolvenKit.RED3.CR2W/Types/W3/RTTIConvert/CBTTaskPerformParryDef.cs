using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskPerformParryDef : CBTTaskPlayAnimationEventDecoratorDef
	{
		[Ordinal(1)] [RED("activationTimeLimitBonusHeavy")] 		public CBehTreeValFloat ActivationTimeLimitBonusHeavy { get; set;}

		[Ordinal(2)] [RED("activationTimeLimitBonusLight")] 		public CBehTreeValFloat ActivationTimeLimitBonusLight { get; set;}

		[Ordinal(3)] [RED("checkParryChance")] 		public CBool CheckParryChance { get; set;}

		[Ordinal(4)] [RED("interruptTaskToExecuteCounter")] 		public CBool InterruptTaskToExecuteCounter { get; set;}

		[Ordinal(5)] [RED("allowParryOverlap")] 		public CBool AllowParryOverlap { get; set;}

		public CBTTaskPerformParryDef(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskPerformParryDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}