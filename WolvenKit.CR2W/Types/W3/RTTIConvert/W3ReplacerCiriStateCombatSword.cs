using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3ReplacerCiriStateCombatSword : CR4PlayerStateCombat
	{
		[RED("specialAttackHeading")] 		public CFloat SpecialAttackHeading { get; set;}

		[RED("completeSpecialAttackDist")] 		public CFloat CompleteSpecialAttackDist { get; set;}

		[RED("specialAttackStartTimeStamp")] 		public CFloat SpecialAttackStartTimeStamp { get; set;}

		[RED("isCompletingSpecialAttack")] 		public CBool IsCompletingSpecialAttack { get; set;}

		[RED("specialAttackSphere")] 		public CHandle<CMeshComponent> SpecialAttackSphere { get; set;}

		[RED("specialAttackSphereEnt")] 		public CHandle<CEntity> SpecialAttackSphereEnt { get; set;}

		[RED("specialAttackEffectTemplate")] 		public CHandle<CEntityTemplate> SpecialAttackEffectTemplate { get; set;}

		[RED("ciriPhantomTemplate")] 		public CHandle<CEntityTemplate> CiriPhantomTemplate { get; set;}

		[RED("ciriGhostFxTemplate")] 		public CHandle<CEntityTemplate> CiriGhostFxTemplate { get; set;}

		[RED("buttonWasHeld")] 		public CBool ButtonWasHeld { get; set;}

		[RED("specialAttackRadius")] 		public CFloat SpecialAttackRadius { get; set;}

		[RED("specialAttackInterrupted")] 		public CBool SpecialAttackInterrupted { get; set;}

		[RED("HOLD_SPECIAL_ATTACK_BUTTON_TIME")] 		public CFloat HOLD_SPECIAL_ATTACK_BUTTON_TIME { get; set;}

		[RED("ATTACK_RADIUS_INITIAL_VAL")] 		public CFloat ATTACK_RADIUS_INITIAL_VAL { get; set;}

		[RED("ATTACK_RADIUS_MAXIMUM_VAL")] 		public CFloat ATTACK_RADIUS_MAXIMUM_VAL { get; set;}

		[RED("ATTACK_RADIUS_INCREASE_SPEED")] 		public CFloat ATTACK_RADIUS_INCREASE_SPEED { get; set;}

		[RED("SPECIAL_ATTACK_MAX_TARGETS")] 		public CInt32 SPECIAL_ATTACK_MAX_TARGETS { get; set;}

		[RED("DODGE_DISTANCE")] 		public CFloat DODGE_DISTANCE { get; set;}

		[RED("DASH_DISTANCE")] 		public CFloat DASH_DISTANCE { get; set;}

		[RED("SPECIAL_ATTACK_HEAVY_MAX_DIST")] 		public CFloat SPECIAL_ATTACK_HEAVY_MAX_DIST { get; set;}

		[RED("teleportToLastPos")] 		public CBool TeleportToLastPos { get; set;}

		[RED("lastTarget")] 		public CHandle<CActor> LastTarget { get; set;}

		[RED("_distances", 2,0)] 		public CArray<CFloat> _distances { get; set;}

		[RED("_vectors", 2,0)] 		public CArray<Vector> _vectors { get; set;}

		[RED("attackAnimsListLP", 2,0)] 		public CArray<CName> AttackAnimsListLP { get; set;}

		[RED("attackAnimsListRP", 2,0)] 		public CArray<CName> AttackAnimsListRP { get; set;}

		public W3ReplacerCiriStateCombatSword(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3ReplacerCiriStateCombatSword(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}