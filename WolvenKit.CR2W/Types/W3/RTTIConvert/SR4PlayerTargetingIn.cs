using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SR4PlayerTargetingIn : CVariable
	{
		[Ordinal(1)] [RED("canFindTarget")] 		public CBool CanFindTarget { get; set;}

		[Ordinal(2)] [RED("playerHasBlockingBuffs")] 		public CBool PlayerHasBlockingBuffs { get; set;}

		[Ordinal(3)] [RED("isHardLockedToTarget")] 		public CBool IsHardLockedToTarget { get; set;}

		[Ordinal(4)] [RED("isActorLockedToTarget")] 		public CBool IsActorLockedToTarget { get; set;}

		[Ordinal(5)] [RED("isCameraLockedToTarget")] 		public CBool IsCameraLockedToTarget { get; set;}

		[Ordinal(6)] [RED("actionCheck")] 		public CBool ActionCheck { get; set;}

		[Ordinal(7)] [RED("actionInput")] 		public CBool ActionInput { get; set;}

		[Ordinal(8)] [RED("isInCombatAction")] 		public CBool IsInCombatAction { get; set;}

		[Ordinal(9)] [RED("isLAxisReleased")] 		public CBool IsLAxisReleased { get; set;}

		[Ordinal(10)] [RED("isLAxisReleasedAfterCounter")] 		public CBool IsLAxisReleasedAfterCounter { get; set;}

		[Ordinal(11)] [RED("isLAxisReleasedAfterCounterNoCA")] 		public CBool IsLAxisReleasedAfterCounterNoCA { get; set;}

		[Ordinal(12)] [RED("lastAxisInputIsMovement")] 		public CBool LastAxisInputIsMovement { get; set;}

		[Ordinal(13)] [RED("isAiming")] 		public CBool IsAiming { get; set;}

		[Ordinal(14)] [RED("isSwimming")] 		public CBool IsSwimming { get; set;}

		[Ordinal(15)] [RED("isDiving")] 		public CBool IsDiving { get; set;}

		[Ordinal(16)] [RED("isThreatened")] 		public CBool IsThreatened { get; set;}

		[Ordinal(17)] [RED("isCombatMusicEnabled")] 		public CBool IsCombatMusicEnabled { get; set;}

		[Ordinal(18)] [RED("isPcModeEnabled")] 		public CBool IsPcModeEnabled { get; set;}

		[Ordinal(19)] [RED("shouldUsePcModeTargeting")] 		public CBool ShouldUsePcModeTargeting { get; set;}

		[Ordinal(20)] [RED("isInParryOrCounter")] 		public CBool IsInParryOrCounter { get; set;}

		[Ordinal(21)] [RED("bufferActionType")] 		public CEnum<EBufferActionType> BufferActionType { get; set;}

		[Ordinal(22)] [RED("orientationTarget")] 		public CEnum<EOrientationTarget> OrientationTarget { get; set;}

		[Ordinal(23)] [RED("coneDist")] 		public CFloat ConeDist { get; set;}

		[Ordinal(24)] [RED("findMoveTargetDist")] 		public CFloat FindMoveTargetDist { get; set;}

		[Ordinal(25)] [RED("cachedRawPlayerHeading")] 		public CFloat CachedRawPlayerHeading { get; set;}

		[Ordinal(26)] [RED("combatActionHeading")] 		public CFloat CombatActionHeading { get; set;}

		[Ordinal(27)] [RED("rawPlayerHeadingVector")] 		public Vector RawPlayerHeadingVector { get; set;}

		[Ordinal(28)] [RED("lookAtDirection")] 		public Vector LookAtDirection { get; set;}

		[Ordinal(29)] [RED("moveTarget")] 		public CHandle<CActor> MoveTarget { get; set;}

		[Ordinal(30)] [RED("aimingTarget")] 		public CHandle<CActor> AimingTarget { get; set;}

		[Ordinal(31)] [RED("displayTarget")] 		public CHandle<CActor> DisplayTarget { get; set;}

		[Ordinal(32)] [RED("finishableEnemies", 2,0)] 		public CArray<CHandle<CActor>> FinishableEnemies { get; set;}

		[Ordinal(33)] [RED("hostileEnemies", 2,0)] 		public CArray<CHandle<CActor>> HostileEnemies { get; set;}

		[Ordinal(34)] [RED("defaultSelectionWeights")] 		public STargetSelectionWeights DefaultSelectionWeights { get; set;}

		public SR4PlayerTargetingIn(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SR4PlayerTargetingIn(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}