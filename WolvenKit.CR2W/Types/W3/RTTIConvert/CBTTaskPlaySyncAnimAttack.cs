using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskPlaySyncAnimAttack : CBTTaskAttack
	{
		[Ordinal(0)] [RED("("useSetupSimpleSyncAnim2")] 		public CBool UseSetupSimpleSyncAnim2 { get; set;}

		[Ordinal(0)] [RED("("overrideAttackTypes")] 		public CBool OverrideAttackTypes { get; set;}

		[Ordinal(0)] [RED("("disableCollision")] 		public CBool DisableCollision { get; set;}

		[Ordinal(0)] [RED("("syncAttackAnims")] 		public SSyncAttackTypes SyncAttackAnims { get; set;}

		[Ordinal(0)] [RED("("checkConditionsOnIsAvailable")] 		public CBool CheckConditionsOnIsAvailable { get; set;}

		[Ordinal(0)] [RED("("syncAnimNameLeftStance")] 		public CName SyncAnimNameLeftStance { get; set;}

		[Ordinal(0)] [RED("("syncAnimNameRightStance")] 		public CName SyncAnimNameRightStance { get; set;}

		[Ordinal(0)] [RED("("raiseForceIdle")] 		public CBool RaiseForceIdle { get; set;}

		[Ordinal(0)] [RED("("denyWhenTargetIsDodging")] 		public CBool DenyWhenTargetIsDodging { get; set;}

		[Ordinal(0)] [RED("("denyWhenTargetIsGuarded")] 		public CBool DenyWhenTargetIsGuarded { get; set;}

		[Ordinal(0)] [RED("("denyWhenTargetIsUsingQuen")] 		public CBool DenyWhenTargetIsUsingQuen { get; set;}

		[Ordinal(0)] [RED("("permitOnlyWhenTargetIsGuarded")] 		public CBool PermitOnlyWhenTargetIsGuarded { get; set;}

		[Ordinal(0)] [RED("("denyWhenCollidingWithVictirm")] 		public CBool DenyWhenCollidingWithVictirm { get; set;}

		[Ordinal(0)] [RED("("activateOnDistanceBelow")] 		public CFloat ActivateOnDistanceBelow { get; set;}

		[Ordinal(0)] [RED("("activateOnDistanceAbove")] 		public CFloat ActivateOnDistanceAbove { get; set;}

		[Ordinal(0)] [RED("("activateOnAngleBelow")] 		public CFloat ActivateOnAngleBelow { get; set;}

		[Ordinal(0)] [RED("("checkMoveType")] 		public CBool CheckMoveType { get; set;}

		[Ordinal(0)] [RED("("activateOnGreaterEqualMoveType")] 		public CEnum<EMoveType> ActivateOnGreaterEqualMoveType { get; set;}

		[Ordinal(0)] [RED("("zTolerance")] 		public CFloat ZTolerance { get; set;}

		[Ordinal(0)] [RED("("denyIfTargetNotPlayer")] 		public CBool DenyIfTargetNotPlayer { get; set;}

		[Ordinal(0)] [RED("("onAnimEvent")] 		public CName OnAnimEvent { get; set;}

		[Ordinal(0)] [RED("("onGameplayEvent")] 		public CName OnGameplayEvent { get; set;}

		[Ordinal(0)] [RED("("completeOnMainEnd")] 		public CBool CompleteOnMainEnd { get; set;}

		[Ordinal(0)] [RED("("activated")] 		public CBool Activated { get; set;}

		[Ordinal(0)] [RED("("npc")] 		public CHandle<CNewNPC> Npc { get; set;}

		[Ordinal(0)] [RED("("target")] 		public CHandle<CActor> Target { get; set;}

		[Ordinal(0)] [RED("("component")] 		public CHandle<CAnimatedComponent> Component { get; set;}

		public CBTTaskPlaySyncAnimAttack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskPlaySyncAnimAttack(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}