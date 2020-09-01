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
		[Ordinal(1)] [RED("("useSetupSimpleSyncAnim2")] 		public CBool UseSetupSimpleSyncAnim2 { get; set;}

		[Ordinal(2)] [RED("("overrideAttackTypes")] 		public CBool OverrideAttackTypes { get; set;}

		[Ordinal(3)] [RED("("disableCollision")] 		public CBool DisableCollision { get; set;}

		[Ordinal(4)] [RED("("syncAttackAnims")] 		public SSyncAttackTypes SyncAttackAnims { get; set;}

		[Ordinal(5)] [RED("("checkConditionsOnIsAvailable")] 		public CBool CheckConditionsOnIsAvailable { get; set;}

		[Ordinal(6)] [RED("("syncAnimNameLeftStance")] 		public CName SyncAnimNameLeftStance { get; set;}

		[Ordinal(7)] [RED("("syncAnimNameRightStance")] 		public CName SyncAnimNameRightStance { get; set;}

		[Ordinal(8)] [RED("("raiseForceIdle")] 		public CBool RaiseForceIdle { get; set;}

		[Ordinal(9)] [RED("("denyWhenTargetIsDodging")] 		public CBool DenyWhenTargetIsDodging { get; set;}

		[Ordinal(10)] [RED("("denyWhenTargetIsGuarded")] 		public CBool DenyWhenTargetIsGuarded { get; set;}

		[Ordinal(11)] [RED("("denyWhenTargetIsUsingQuen")] 		public CBool DenyWhenTargetIsUsingQuen { get; set;}

		[Ordinal(12)] [RED("("permitOnlyWhenTargetIsGuarded")] 		public CBool PermitOnlyWhenTargetIsGuarded { get; set;}

		[Ordinal(13)] [RED("("denyWhenCollidingWithVictirm")] 		public CBool DenyWhenCollidingWithVictirm { get; set;}

		[Ordinal(14)] [RED("("activateOnDistanceBelow")] 		public CFloat ActivateOnDistanceBelow { get; set;}

		[Ordinal(15)] [RED("("activateOnDistanceAbove")] 		public CFloat ActivateOnDistanceAbove { get; set;}

		[Ordinal(16)] [RED("("activateOnAngleBelow")] 		public CFloat ActivateOnAngleBelow { get; set;}

		[Ordinal(17)] [RED("("checkMoveType")] 		public CBool CheckMoveType { get; set;}

		[Ordinal(18)] [RED("("activateOnGreaterEqualMoveType")] 		public CEnum<EMoveType> ActivateOnGreaterEqualMoveType { get; set;}

		[Ordinal(19)] [RED("("zTolerance")] 		public CFloat ZTolerance { get; set;}

		[Ordinal(20)] [RED("("denyIfTargetNotPlayer")] 		public CBool DenyIfTargetNotPlayer { get; set;}

		[Ordinal(21)] [RED("("onAnimEvent")] 		public CName OnAnimEvent { get; set;}

		[Ordinal(22)] [RED("("onGameplayEvent")] 		public CName OnGameplayEvent { get; set;}

		[Ordinal(23)] [RED("("completeOnMainEnd")] 		public CBool CompleteOnMainEnd { get; set;}

		[Ordinal(24)] [RED("("activated")] 		public CBool Activated { get; set;}

		[Ordinal(25)] [RED("("npc")] 		public CHandle<CNewNPC> Npc { get; set;}

		[Ordinal(26)] [RED("("target")] 		public CHandle<CActor> Target { get; set;}

		[Ordinal(27)] [RED("("component")] 		public CHandle<CAnimatedComponent> Component { get; set;}

		public CBTTaskPlaySyncAnimAttack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskPlaySyncAnimAttack(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}