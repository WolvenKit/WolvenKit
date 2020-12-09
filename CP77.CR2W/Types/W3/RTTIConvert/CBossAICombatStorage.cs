using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBossAICombatStorage : CHumanAICombatStorage
	{
		[Ordinal(1)] [RED("isLightbringerAvailable")] 		public CBool IsLightbringerAvailable { get; set;}

		[Ordinal(2)] [RED("isMeteoritesAvailable")] 		public CBool IsMeteoritesAvailable { get; set;}

		[Ordinal(3)] [RED("isIceSpikesAvailable")] 		public CBool IsIceSpikesAvailable { get; set;}

		[Ordinal(4)] [RED("isBlinkComboAvailable")] 		public CBool IsBlinkComboAvailable { get; set;}

		[Ordinal(5)] [RED("isSpecialAttackAvailable")] 		public CBool IsSpecialAttackAvailable { get; set;}

		[Ordinal(6)] [RED("isParryAvailable")] 		public CBool IsParryAvailable { get; set;}

		[Ordinal(7)] [RED("isSiphonAvailable")] 		public CBool IsSiphonAvailable { get; set;}

		[Ordinal(8)] [RED("isDodgeAvailable")] 		public CBool IsDodgeAvailable { get; set;}

		[Ordinal(9)] [RED("isStaminaRegenAvailable")] 		public CBool IsStaminaRegenAvailable { get; set;}

		[Ordinal(10)] [RED("isPhaseChangeAvailable")] 		public CBool IsPhaseChangeAvailable { get; set;}

		[Ordinal(11)] [RED("inInSpecialAttack")] 		public CBool InInSpecialAttack { get; set;}

		public CBossAICombatStorage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBossAICombatStorage(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}