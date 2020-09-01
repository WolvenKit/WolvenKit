using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SR4PlayerTargetingIn : CVariable
	{
		[Ordinal(0)] [RED("("canFindTarget")] 		public CBool CanFindTarget { get; set;}

		[Ordinal(0)] [RED("("playerHasBlockingBuffs")] 		public CBool PlayerHasBlockingBuffs { get; set;}

		[Ordinal(0)] [RED("("isHardLockedToTarget")] 		public CBool IsHardLockedToTarget { get; set;}

		[Ordinal(0)] [RED("("isActorLockedToTarget")] 		public CBool IsActorLockedToTarget { get; set;}

		[Ordinal(0)] [RED("("isCameraLockedToTarget")] 		public CBool IsCameraLockedToTarget { get; set;}

		[Ordinal(0)] [RED("("actionCheck")] 		public CBool ActionCheck { get; set;}

		[Ordinal(0)] [RED("("actionInput")] 		public CBool ActionInput { get; set;}

		[Ordinal(0)] [RED("("isInCombatAction")] 		public CBool IsInCombatAction { get; set;}

		[Ordinal(0)] [RED("("isLAxisReleased")] 		public CBool IsLAxisReleased { get; set;}

		[Ordinal(0)] [RED("("isLAxisReleasedAfterCounter")] 		public CBool IsLAxisReleasedAfterCounter { get; set;}

		[Ordinal(0)] [RED("("isLAxisReleasedAfterCounterNoCA")] 		public CBool IsLAxisReleasedAfterCounterNoCA { get; set;}

		[Ordinal(0)] [RED("("lastAxisInputIsMovement")] 		public CBool LastAxisInputIsMovement { get; set;}

		[Ordinal(0)] [RED("("isAiming")] 		public CBool IsAiming { get; set;}

		[Ordinal(0)] [RED("("isSwimming")] 		public CBool IsSwimming { get; set;}

		[Ordinal(0)] [RED("("isDiving")] 		public CBool IsDiving { get; set;}

		[Ordinal(0)] [RED("("isThreatened")] 		public CBool IsThreatened { get; set;}

		[Ordinal(0)] [RED("("isCombatMusicEnabled")] 		public CBool IsCombatMusicEnabled { get; set;}

		[Ordinal(0)] [RED("("isPcModeEnabled")] 		public CBool IsPcModeEnabled { get; set;}

		[Ordinal(0)] [RED("("shouldUsePcModeTargeting")] 		public CBool ShouldUsePcModeTargeting { get; set;}

		[Ordinal(0)] [RED("("isInParryOrCounter")] 		public CBool IsInParryOrCounter { get; set;}

		[Ordinal(0)] [RED("("bufferActionType")] 		public CEnum<EBufferActionType> BufferActionType { get; set;}

		[Ordinal(0)] [RED("("orientationTarget")] 		public CEnum<EOrientationTarget> OrientationTarget { get; set;}

		[Ordinal(0)] [RED("("coneDist")] 		public CFloat ConeDist { get; set;}

		[Ordinal(0)] [RED("("findMoveTargetDist")] 		public CFloat FindMoveTargetDist { get; set;}

		[Ordinal(0)] [RED("("cachedRawPlayerHeading")] 		public CFloat CachedRawPlayerHeading { get; set;}

		[Ordinal(0)] [RED("("combatActionHeading")] 		public CFloat CombatActionHeading { get; set;}

		[Ordinal(0)] [RED("("rawPlayerHeadingVector")] 		public Vector RawPlayerHeadingVector { get; set;}

		[Ordinal(0)] [RED("("lookAtDirection")] 		public Vector LookAtDirection { get; set;}

		[Ordinal(0)] [RED("("moveTarget")] 		public CHandle<CActor> MoveTarget { get; set;}

		[Ordinal(0)] [RED("("aimingTarget")] 		public CHandle<CActor> AimingTarget { get; set;}

		[Ordinal(0)] [RED("("displayTarget")] 		public CHandle<CActor> DisplayTarget { get; set;}

		[Ordinal(0)] [RED("("finishableEnemies", 2,0)] 		public CArray<CHandle<CActor>> FinishableEnemies { get; set;}

		[Ordinal(0)] [RED("("hostileEnemies", 2,0)] 		public CArray<CHandle<CActor>> HostileEnemies { get; set;}

		[Ordinal(0)] [RED("("defaultSelectionWeights")] 		public STargetSelectionWeights DefaultSelectionWeights { get; set;}

		public SR4PlayerTargetingIn(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SR4PlayerTargetingIn(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}