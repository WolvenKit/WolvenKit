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
		[RED("canFindTarget")] 		public CBool CanFindTarget { get; set;}

		[RED("playerHasBlockingBuffs")] 		public CBool PlayerHasBlockingBuffs { get; set;}

		[RED("isHardLockedToTarget")] 		public CBool IsHardLockedToTarget { get; set;}

		[RED("isActorLockedToTarget")] 		public CBool IsActorLockedToTarget { get; set;}

		[RED("isCameraLockedToTarget")] 		public CBool IsCameraLockedToTarget { get; set;}

		[RED("actionCheck")] 		public CBool ActionCheck { get; set;}

		[RED("actionInput")] 		public CBool ActionInput { get; set;}

		[RED("isInCombatAction")] 		public CBool IsInCombatAction { get; set;}

		[RED("isLAxisReleased")] 		public CBool IsLAxisReleased { get; set;}

		[RED("isLAxisReleasedAfterCounter")] 		public CBool IsLAxisReleasedAfterCounter { get; set;}

		[RED("isLAxisReleasedAfterCounterNoCA")] 		public CBool IsLAxisReleasedAfterCounterNoCA { get; set;}

		[RED("lastAxisInputIsMovement")] 		public CBool LastAxisInputIsMovement { get; set;}

		[RED("isAiming")] 		public CBool IsAiming { get; set;}

		[RED("isSwimming")] 		public CBool IsSwimming { get; set;}

		[RED("isDiving")] 		public CBool IsDiving { get; set;}

		[RED("isThreatened")] 		public CBool IsThreatened { get; set;}

		[RED("isCombatMusicEnabled")] 		public CBool IsCombatMusicEnabled { get; set;}

		[RED("isPcModeEnabled")] 		public CBool IsPcModeEnabled { get; set;}

		[RED("shouldUsePcModeTargeting")] 		public CBool ShouldUsePcModeTargeting { get; set;}

		[RED("isInParryOrCounter")] 		public CBool IsInParryOrCounter { get; set;}

		[RED("bufferActionType")] 		public CEnum<EBufferActionType> BufferActionType { get; set;}

		[RED("orientationTarget")] 		public CEnum<EOrientationTarget> OrientationTarget { get; set;}

		[RED("coneDist")] 		public CFloat ConeDist { get; set;}

		[RED("findMoveTargetDist")] 		public CFloat FindMoveTargetDist { get; set;}

		[RED("cachedRawPlayerHeading")] 		public CFloat CachedRawPlayerHeading { get; set;}

		[RED("combatActionHeading")] 		public CFloat CombatActionHeading { get; set;}

		[RED("rawPlayerHeadingVector")] 		public Vector RawPlayerHeadingVector { get; set;}

		[RED("lookAtDirection")] 		public Vector LookAtDirection { get; set;}

		[RED("moveTarget")] 		public CHandle<CActor> MoveTarget { get; set;}

		[RED("aimingTarget")] 		public CHandle<CActor> AimingTarget { get; set;}

		[RED("displayTarget")] 		public CHandle<CActor> DisplayTarget { get; set;}

		[RED("finishableEnemies", 2,0)] 		public CArray<CHandle<CActor>> FinishableEnemies { get; set;}

		[RED("hostileEnemies", 2,0)] 		public CArray<CHandle<CActor>> HostileEnemies { get; set;}

		[RED("defaultSelectionWeights")] 		public STargetSelectionWeights DefaultSelectionWeights { get; set;}

		public SR4PlayerTargetingIn(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SR4PlayerTargetingIn(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}