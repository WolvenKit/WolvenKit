using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3VehicleCombatManagerStateSwordAttack : CScriptableState
	{
		[Ordinal(0)] [RED("("rider")] 		public CHandle<CR4Player> Rider { get; set;}

		[Ordinal(0)] [RED("("horizontalVal")] 		public CFloat HorizontalVal { get; set;}

		[Ordinal(0)] [RED("("speedMultCasuserId")] 		public CInt32 SpeedMultCasuserId { get; set;}

		[Ordinal(0)] [RED("("slowMoSpeedCurrVal")] 		public CFloat SlowMoSpeedCurrVal { get; set;}

		[Ordinal(0)] [RED("("slowMoVelocityCurrVal")] 		public CFloat SlowMoVelocityCurrVal { get; set;}

		[Ordinal(0)] [RED("("isSlowMoOn")] 		public CBool IsSlowMoOn { get; set;}

		[Ordinal(0)] [RED("("ATTACK_TIMEOUT")] 		public CFloat ATTACK_TIMEOUT { get; set;}

		[Ordinal(0)] [RED("("ATTACK_STAMINA_PER_SEC")] 		public CFloat ATTACK_STAMINA_PER_SEC { get; set;}

		[Ordinal(0)] [RED("("ATTACK_COOLDOWN")] 		public CFloat ATTACK_COOLDOWN { get; set;}

		[Ordinal(0)] [RED("("CHANGE_SIDE_THRESHOLD")] 		public CFloat CHANGE_SIDE_THRESHOLD { get; set;}

		[Ordinal(0)] [RED("("attackInProgress")] 		public CBool AttackInProgress { get; set;}

		[Ordinal(0)] [RED("("FIRST_SWEEP_DELAY")] 		public CFloat FIRST_SWEEP_DELAY { get; set;}

		[Ordinal(0)] [RED("("SECOND_SWEEP_DELAY")] 		public CFloat SECOND_SWEEP_DELAY { get; set;}

		[Ordinal(0)] [RED("("BASE_DAMAGE")] 		public CFloat BASE_DAMAGE { get; set;}

		public W3VehicleCombatManagerStateSwordAttack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3VehicleCombatManagerStateSwordAttack(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}