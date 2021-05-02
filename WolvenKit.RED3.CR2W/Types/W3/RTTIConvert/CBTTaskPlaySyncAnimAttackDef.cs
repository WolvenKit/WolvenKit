using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskPlaySyncAnimAttackDef : CBTTaskAttackDef
	{
		[Ordinal(1)] [RED("disableCollision")] 		public CBool DisableCollision { get; set;}

		[Ordinal(2)] [RED("useSetupSimpleSyncAnim2")] 		public CBool UseSetupSimpleSyncAnim2 { get; set;}

		[Ordinal(3)] [RED("overrideAttackTypes")] 		public CBool OverrideAttackTypes { get; set;}

		[Ordinal(4)] [RED("syncAttackAnims")] 		public SSyncAttackTypes SyncAttackAnims { get; set;}

		[Ordinal(5)] [RED("checkConditionsOnIsAvailable")] 		public CBool CheckConditionsOnIsAvailable { get; set;}

		[Ordinal(6)] [RED("syncAnimNameLeftStance")] 		public CName SyncAnimNameLeftStance { get; set;}

		[Ordinal(7)] [RED("syncAnimNameRightStance")] 		public CName SyncAnimNameRightStance { get; set;}

		[Ordinal(8)] [RED("raiseForceIdle")] 		public CBool RaiseForceIdle { get; set;}

		[Ordinal(9)] [RED("denyWhenTargetIsDodging")] 		public CBool DenyWhenTargetIsDodging { get; set;}

		[Ordinal(10)] [RED("denyWhenTargetIsGuarded")] 		public CBool DenyWhenTargetIsGuarded { get; set;}

		[Ordinal(11)] [RED("denyWhenTargetIsUsingQuen")] 		public CBool DenyWhenTargetIsUsingQuen { get; set;}

		[Ordinal(12)] [RED("permitOnlyWhenTargetIsGuarded")] 		public CBool PermitOnlyWhenTargetIsGuarded { get; set;}

		[Ordinal(13)] [RED("denyWhenCollidingWithVictirm")] 		public CBool DenyWhenCollidingWithVictirm { get; set;}

		[Ordinal(14)] [RED("activateOnDistanceBelow")] 		public CFloat ActivateOnDistanceBelow { get; set;}

		[Ordinal(15)] [RED("activateOnDistanceAbove")] 		public CFloat ActivateOnDistanceAbove { get; set;}

		[Ordinal(16)] [RED("activateOnAngleBelow")] 		public CFloat ActivateOnAngleBelow { get; set;}

		[Ordinal(17)] [RED("checkMoveType")] 		public CBool CheckMoveType { get; set;}

		[Ordinal(18)] [RED("activateOnGreaterEqualMoveType")] 		public CEnum<EMoveType> ActivateOnGreaterEqualMoveType { get; set;}

		[Ordinal(19)] [RED("zTolerance")] 		public CFloat ZTolerance { get; set;}

		[Ordinal(20)] [RED("denyIfTargetNotPlayer")] 		public CBool DenyIfTargetNotPlayer { get; set;}

		[Ordinal(21)] [RED("onAnimEvent")] 		public CName OnAnimEvent { get; set;}

		[Ordinal(22)] [RED("onGameplayEvent")] 		public CName OnGameplayEvent { get; set;}

		[Ordinal(23)] [RED("completeOnMainEnd")] 		public CBool CompleteOnMainEnd { get; set;}

		public CBTTaskPlaySyncAnimAttackDef(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskPlaySyncAnimAttackDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}