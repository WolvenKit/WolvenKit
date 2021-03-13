using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3ReplacerCiriStateCombatSword : CR4PlayerStateCombat
	{
		[Ordinal(1)] [RED("specialAttackHeading")] 		public CFloat SpecialAttackHeading { get; set;}

		[Ordinal(2)] [RED("completeSpecialAttackDist")] 		public CFloat CompleteSpecialAttackDist { get; set;}

		[Ordinal(3)] [RED("specialAttackStartTimeStamp")] 		public CFloat SpecialAttackStartTimeStamp { get; set;}

		[Ordinal(4)] [RED("isCompletingSpecialAttack")] 		public CBool IsCompletingSpecialAttack { get; set;}

		[Ordinal(5)] [RED("specialAttackSphere")] 		public CHandle<CMeshComponent> SpecialAttackSphere { get; set;}

		[Ordinal(6)] [RED("specialAttackSphereEnt")] 		public CHandle<CEntity> SpecialAttackSphereEnt { get; set;}

		[Ordinal(7)] [RED("specialAttackEffectTemplate")] 		public CHandle<CEntityTemplate> SpecialAttackEffectTemplate { get; set;}

		[Ordinal(8)] [RED("ciriPhantomTemplate")] 		public CHandle<CEntityTemplate> CiriPhantomTemplate { get; set;}

		[Ordinal(9)] [RED("ciriGhostFxTemplate")] 		public CHandle<CEntityTemplate> CiriGhostFxTemplate { get; set;}

		[Ordinal(10)] [RED("buttonWasHeld")] 		public CBool ButtonWasHeld { get; set;}

		[Ordinal(11)] [RED("specialAttackRadius")] 		public CFloat SpecialAttackRadius { get; set;}

		[Ordinal(12)] [RED("specialAttackInterrupted")] 		public CBool SpecialAttackInterrupted { get; set;}

		[Ordinal(13)] [RED("HOLD_SPECIAL_ATTACK_BUTTON_TIME")] 		public CFloat HOLD_SPECIAL_ATTACK_BUTTON_TIME { get; set;}

		[Ordinal(14)] [RED("ATTACK_RADIUS_INITIAL_VAL")] 		public CFloat ATTACK_RADIUS_INITIAL_VAL { get; set;}

		[Ordinal(15)] [RED("ATTACK_RADIUS_MAXIMUM_VAL")] 		public CFloat ATTACK_RADIUS_MAXIMUM_VAL { get; set;}

		[Ordinal(16)] [RED("ATTACK_RADIUS_INCREASE_SPEED")] 		public CFloat ATTACK_RADIUS_INCREASE_SPEED { get; set;}

		[Ordinal(17)] [RED("SPECIAL_ATTACK_MAX_TARGETS")] 		public CInt32 SPECIAL_ATTACK_MAX_TARGETS { get; set;}

		[Ordinal(18)] [RED("DODGE_DISTANCE")] 		public CFloat DODGE_DISTANCE { get; set;}

		[Ordinal(19)] [RED("DASH_DISTANCE")] 		public CFloat DASH_DISTANCE { get; set;}

		[Ordinal(20)] [RED("SPECIAL_ATTACK_HEAVY_MAX_DIST")] 		public CFloat SPECIAL_ATTACK_HEAVY_MAX_DIST { get; set;}

		[Ordinal(21)] [RED("teleportToLastPos")] 		public CBool TeleportToLastPos { get; set;}

		[Ordinal(22)] [RED("lastTarget")] 		public CHandle<CActor> LastTarget { get; set;}

		[Ordinal(23)] [RED("_distances", 2,0)] 		public CArray<CFloat> _distances { get; set;}

		[Ordinal(24)] [RED("_vectors", 2,0)] 		public CArray<Vector> _vectors { get; set;}

		[Ordinal(25)] [RED("attackAnimsListLP", 2,0)] 		public CArray<CName> AttackAnimsListLP { get; set;}

		[Ordinal(26)] [RED("attackAnimsListRP", 2,0)] 		public CArray<CName> AttackAnimsListRP { get; set;}

		public W3ReplacerCiriStateCombatSword(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3ReplacerCiriStateCombatSword(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}