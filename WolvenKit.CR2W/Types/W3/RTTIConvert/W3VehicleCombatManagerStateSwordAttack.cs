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
		[RED("rider")] 		public CHandle<CR4Player> Rider { get; set;}

		[RED("horizontalVal")] 		public CFloat HorizontalVal { get; set;}

		[RED("speedMultCasuserId")] 		public CInt32 SpeedMultCasuserId { get; set;}

		[RED("slowMoSpeedCurrVal")] 		public CFloat SlowMoSpeedCurrVal { get; set;}

		[RED("slowMoVelocityCurrVal")] 		public CFloat SlowMoVelocityCurrVal { get; set;}

		[RED("isSlowMoOn")] 		public CBool IsSlowMoOn { get; set;}

		[RED("ATTACK_TIMEOUT")] 		public CFloat ATTACK_TIMEOUT { get; set;}

		[RED("ATTACK_STAMINA_PER_SEC")] 		public CFloat ATTACK_STAMINA_PER_SEC { get; set;}

		[RED("ATTACK_COOLDOWN")] 		public CFloat ATTACK_COOLDOWN { get; set;}

		[RED("CHANGE_SIDE_THRESHOLD")] 		public CFloat CHANGE_SIDE_THRESHOLD { get; set;}

		[RED("attackInProgress")] 		public CBool AttackInProgress { get; set;}

		[RED("FIRST_SWEEP_DELAY")] 		public CFloat FIRST_SWEEP_DELAY { get; set;}

		[RED("SECOND_SWEEP_DELAY")] 		public CFloat SECOND_SWEEP_DELAY { get; set;}

		[RED("BASE_DAMAGE")] 		public CFloat BASE_DAMAGE { get; set;}

		public W3VehicleCombatManagerStateSwordAttack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3VehicleCombatManagerStateSwordAttack(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}