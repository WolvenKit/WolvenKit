using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBossAICombatStorage : CHumanAICombatStorage
	{
		[Ordinal(0)] [RED("isLightbringerAvailable")] 		public CBool IsLightbringerAvailable { get; set;}

		[Ordinal(0)] [RED("isMeteoritesAvailable")] 		public CBool IsMeteoritesAvailable { get; set;}

		[Ordinal(0)] [RED("isIceSpikesAvailable")] 		public CBool IsIceSpikesAvailable { get; set;}

		[Ordinal(0)] [RED("isBlinkComboAvailable")] 		public CBool IsBlinkComboAvailable { get; set;}

		[Ordinal(0)] [RED("isSpecialAttackAvailable")] 		public CBool IsSpecialAttackAvailable { get; set;}

		[Ordinal(0)] [RED("isParryAvailable")] 		public CBool IsParryAvailable { get; set;}

		[Ordinal(0)] [RED("isSiphonAvailable")] 		public CBool IsSiphonAvailable { get; set;}

		[Ordinal(0)] [RED("isDodgeAvailable")] 		public CBool IsDodgeAvailable { get; set;}

		[Ordinal(0)] [RED("isStaminaRegenAvailable")] 		public CBool IsStaminaRegenAvailable { get; set;}

		[Ordinal(0)] [RED("isPhaseChangeAvailable")] 		public CBool IsPhaseChangeAvailable { get; set;}

		[Ordinal(0)] [RED("inInSpecialAttack")] 		public CBool InInSpecialAttack { get; set;}

		public CBossAICombatStorage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBossAICombatStorage(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}