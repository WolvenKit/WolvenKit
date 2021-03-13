using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3VehicleCombatManagerStateSwordAttack : CScriptableState
	{
		[Ordinal(1)] [RED("rider")] 		public CHandle<CR4Player> Rider { get; set;}

		[Ordinal(2)] [RED("horizontalVal")] 		public CFloat HorizontalVal { get; set;}

		[Ordinal(3)] [RED("speedMultCasuserId")] 		public CInt32 SpeedMultCasuserId { get; set;}

		[Ordinal(4)] [RED("slowMoSpeedCurrVal")] 		public CFloat SlowMoSpeedCurrVal { get; set;}

		[Ordinal(5)] [RED("slowMoVelocityCurrVal")] 		public CFloat SlowMoVelocityCurrVal { get; set;}

		[Ordinal(6)] [RED("isSlowMoOn")] 		public CBool IsSlowMoOn { get; set;}

		[Ordinal(7)] [RED("ATTACK_TIMEOUT")] 		public CFloat ATTACK_TIMEOUT { get; set;}

		[Ordinal(8)] [RED("ATTACK_STAMINA_PER_SEC")] 		public CFloat ATTACK_STAMINA_PER_SEC { get; set;}

		[Ordinal(9)] [RED("ATTACK_COOLDOWN")] 		public CFloat ATTACK_COOLDOWN { get; set;}

		[Ordinal(10)] [RED("CHANGE_SIDE_THRESHOLD")] 		public CFloat CHANGE_SIDE_THRESHOLD { get; set;}

		[Ordinal(11)] [RED("attackInProgress")] 		public CBool AttackInProgress { get; set;}

		[Ordinal(12)] [RED("FIRST_SWEEP_DELAY")] 		public CFloat FIRST_SWEEP_DELAY { get; set;}

		[Ordinal(13)] [RED("SECOND_SWEEP_DELAY")] 		public CFloat SECOND_SWEEP_DELAY { get; set;}

		[Ordinal(14)] [RED("BASE_DAMAGE")] 		public CFloat BASE_DAMAGE { get; set;}

		public W3VehicleCombatManagerStateSwordAttack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3VehicleCombatManagerStateSwordAttack(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}