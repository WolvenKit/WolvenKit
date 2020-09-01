using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIAttackBehaviorTreeParams : CAICombatActionParameters
	{
		[Ordinal(0)] [RED("chargeAction")] 		public CBool ChargeAction { get; set;}

		[Ordinal(0)] [RED("approachAction")] 		public CBool ApproachAction { get; set;}

		[Ordinal(0)] [RED("throwBomb")] 		public CBool ThrowBomb { get; set;}

		[Ordinal(0)] [RED("teleportAction")] 		public CBool TeleportAction { get; set;}

		[Ordinal(0)] [RED("attackAction")] 		public CHandle<CAIAttackActionTree> AttackAction { get; set;}

		[Ordinal(0)] [RED("attackActionRange")] 		public CName AttackActionRange { get; set;}

		[Ordinal(0)] [RED("farAttackAction")] 		public CHandle<CAIAttackActionTree> FarAttackAction { get; set;}

		[Ordinal(0)] [RED("farAttackActionRange")] 		public CName FarAttackActionRange { get; set;}

		public CAIAttackBehaviorTreeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAIAttackBehaviorTreeParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}