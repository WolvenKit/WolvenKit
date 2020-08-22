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
		[RED("useSetupSimpleSyncAnim2")] 		public CBool UseSetupSimpleSyncAnim2 { get; set;}

		[RED("overrideAttackTypes")] 		public CBool OverrideAttackTypes { get; set;}

		[RED("disableCollision")] 		public CBool DisableCollision { get; set;}

		[RED("syncAttackAnims")] 		public SSyncAttackTypes SyncAttackAnims { get; set;}

		[RED("checkConditionsOnIsAvailable")] 		public CBool CheckConditionsOnIsAvailable { get; set;}

		[RED("syncAnimNameLeftStance")] 		public CName SyncAnimNameLeftStance { get; set;}

		[RED("syncAnimNameRightStance")] 		public CName SyncAnimNameRightStance { get; set;}

		[RED("raiseForceIdle")] 		public CBool RaiseForceIdle { get; set;}

		[RED("denyWhenTargetIsDodging")] 		public CBool DenyWhenTargetIsDodging { get; set;}

		[RED("denyWhenTargetIsGuarded")] 		public CBool DenyWhenTargetIsGuarded { get; set;}

		[RED("denyWhenTargetIsUsingQuen")] 		public CBool DenyWhenTargetIsUsingQuen { get; set;}

		[RED("permitOnlyWhenTargetIsGuarded")] 		public CBool PermitOnlyWhenTargetIsGuarded { get; set;}

		[RED("denyWhenCollidingWithVictirm")] 		public CBool DenyWhenCollidingWithVictirm { get; set;}

		[RED("activateOnDistanceBelow")] 		public CFloat ActivateOnDistanceBelow { get; set;}

		[RED("activateOnDistanceAbove")] 		public CFloat ActivateOnDistanceAbove { get; set;}

		[RED("activateOnAngleBelow")] 		public CFloat ActivateOnAngleBelow { get; set;}

		[RED("checkMoveType")] 		public CBool CheckMoveType { get; set;}

		[RED("activateOnGreaterEqualMoveType")] 		public CEnum<EMoveType> ActivateOnGreaterEqualMoveType { get; set;}

		[RED("zTolerance")] 		public CFloat ZTolerance { get; set;}

		[RED("denyIfTargetNotPlayer")] 		public CBool DenyIfTargetNotPlayer { get; set;}

		[RED("onAnimEvent")] 		public CName OnAnimEvent { get; set;}

		[RED("onGameplayEvent")] 		public CName OnGameplayEvent { get; set;}

		[RED("completeOnMainEnd")] 		public CBool CompleteOnMainEnd { get; set;}

		[RED("activated")] 		public CBool Activated { get; set;}

		[RED("npc")] 		public CHandle<CNewNPC> Npc { get; set;}

		[RED("target")] 		public CHandle<CActor> Target { get; set;}

		[RED("component")] 		public CHandle<CAnimatedComponent> Component { get; set;}

		public CBTTaskPlaySyncAnimAttack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskPlaySyncAnimAttack(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}