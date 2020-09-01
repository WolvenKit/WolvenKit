using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4PlayerStateCombat : CR4PlayerStateExtendedMovable
	{
		[Ordinal(0)] [RED("comboDefinition")] 		public CHandle<CComboDefinition> ComboDefinition { get; set;}

		[Ordinal(0)] [RED("comboPlayer")] 		public CHandle<CComboPlayer> ComboPlayer { get; set;}

		[Ordinal(0)] [RED("updatePosition")] 		public CBool UpdatePosition { get; set;}

		[Ordinal(0)] [RED("bIsSwitchingDirection")] 		public CBool BIsSwitchingDirection { get; set;}

		[Ordinal(0)] [RED("currentWeapon")] 		public CEnum<EPlayerWeapon> CurrentWeapon { get; set;}

		[Ordinal(0)] [RED("comboAttackA_Id")] 		public CInt32 ComboAttackA_Id { get; set;}

		[Ordinal(0)] [RED("comboAttackA_Target")] 		public CHandle<CGameplayEntity> ComboAttackA_Target { get; set;}

		[Ordinal(0)] [RED("comboAttackA_Sliding")] 		public CBool ComboAttackA_Sliding { get; set;}

		[Ordinal(0)] [RED("comboAttackB_Id")] 		public CInt32 ComboAttackB_Id { get; set;}

		[Ordinal(0)] [RED("comboAttackB_Target")] 		public CHandle<CGameplayEntity> ComboAttackB_Target { get; set;}

		[Ordinal(0)] [RED("comboAttackB_Sliding")] 		public CBool ComboAttackB_Sliding { get; set;}

		[Ordinal(0)] [RED("comboAspectName")] 		public CName ComboAspectName { get; set;}

		[Ordinal(0)] [RED("enemiesInRange", 2,0)] 		public CArray<CHandle<CActor>> EnemiesInRange { get; set;}

		[Ordinal(0)] [RED("positionWeightsDest", 2,0)] 		public CArray<CFloat> PositionWeightsDest { get; set;}

		[Ordinal(0)] [RED("positionWeights", 2,0)] 		public CArray<CFloat> PositionWeights { get; set;}

		[Ordinal(0)] [RED("positionVelocity", 2,0)] 		public CArray<CFloat> PositionVelocity { get; set;}

		[Ordinal(0)] [RED("positionWeightDamper")] 		public CHandle<SpringDamper> PositionWeightDamper { get; set;}

		[Ordinal(0)] [RED("dodgeDirection")] 		public CEnum<EPlayerEvadeDirection> DodgeDirection { get; set;}

		[Ordinal(0)] [RED("zoomOutForApproachingAttacker")] 		public CBool ZoomOutForApproachingAttacker { get; set;}

		[Ordinal(0)] [RED("slideDistanceOffset")] 		public CFloat SlideDistanceOffset { get; set;}

		[Ordinal(0)] [RED("startupAction")] 		public CEnum<EInitialAction> StartupAction { get; set;}

		[Ordinal(0)] [RED("startupBuff")] 		public CHandle<CBaseGameplayEffect> StartupBuff { get; set;}

		[Ordinal(0)] [RED("isInCriticalState")] 		public CBool IsInCriticalState { get; set;}

		[Ordinal(0)] [RED("realCombat")] 		public CBool RealCombat { get; set;}

		[Ordinal(0)] [RED("lastVitality")] 		public CFloat LastVitality { get; set;}

		[Ordinal(0)] [RED("timeToCheckCombatEndCur")] 		public CFloat TimeToCheckCombatEndCur { get; set;}

		[Ordinal(0)] [RED("timeToCheckCombatEndMax")] 		public CFloat TimeToCheckCombatEndMax { get; set;}

		[Ordinal(0)] [RED("timeToExitCombatFromSprinting")] 		public CFloat TimeToExitCombatFromSprinting { get; set;}

		[Ordinal(0)] [RED("cFMCameraZoomIsEnabled")] 		public CBool CFMCameraZoomIsEnabled { get; set;}

		[Ordinal(0)] [RED("cachedStance")] 		public CEnum<EPlayerCombatStance> CachedStance { get; set;}

		[Ordinal(0)] [RED("disableCombatStanceTimer")] 		public CBool DisableCombatStanceTimer { get; set;}

		[Ordinal(0)] [RED("evadeTarget")] 		public CHandle<CActor> EvadeTarget { get; set;}

		[Ordinal(0)] [RED("wasLockedToTarget")] 		public CBool WasLockedToTarget { get; set;}

		[Ordinal(0)] [RED("angle")] 		public CFloat Angle { get; set;}

		[Ordinal(0)] [RED("cachedDodgeDirection")] 		public CEnum<EPlayerEvadeDirection> CachedDodgeDirection { get; set;}

		[Ordinal(0)] [RED("prevRawLeftJoyRot")] 		public CFloat PrevRawLeftJoyRot { get; set;}

		[Ordinal(0)] [RED("evadeTargetPos")] 		public Vector EvadeTargetPos { get; set;}

		[Ordinal(0)] [RED("cachedRawDodgeHeading")] 		public CFloat CachedRawDodgeHeading { get; set;}

		[Ordinal(0)] [RED("turnInPlaceBeforeDodge")] 		public CBool TurnInPlaceBeforeDodge { get; set;}

		[Ordinal(0)] [RED("dodgePlaylistFwd", 2,0)] 		public CArray<CFloat> DodgePlaylistFwd { get; set;}

		[Ordinal(0)] [RED("dodgePlaylistFlipFwd", 2,0)] 		public CArray<CFloat> DodgePlaylistFlipFwd { get; set;}

		[Ordinal(0)] [RED("dodgePlaylistBck", 2,0)] 		public CArray<CFloat> DodgePlaylistBck { get; set;}

		[Ordinal(0)] [RED("cachedPlayerAttackType")] 		public CName CachedPlayerAttackType { get; set;}

		[Ordinal(0)] [RED("farAttackMinDist")] 		public CFloat FarAttackMinDist { get; set;}

		[Ordinal(0)] [RED("previousSlideTarget")] 		public CHandle<CGameplayEntity> PreviousSlideTarget { get; set;}

		[Ordinal(0)] [RED("finisherDist")] 		public CFloat FinisherDist { get; set;}

		[Ordinal(0)] [RED("isOnHighSlope")] 		public CBool IsOnHighSlope { get; set;}

		[Ordinal(0)] [RED("prevPlayerToTargetDist")] 		public CFloat PrevPlayerToTargetDist { get; set;}

		[Ordinal(0)] [RED("wasDecreasing")] 		public CBool WasDecreasing { get; set;}

		[Ordinal(0)] [RED("enableSoftLock")] 		public CBool EnableSoftLock { get; set;}

		[Ordinal(0)] [RED("wasInCloseCombat")] 		public CBool WasInCloseCombat { get; set;}

		[Ordinal(0)] [RED("ticketRequests", 2,0)] 		public CArray<CInt32> TicketRequests { get; set;}

		[Ordinal(0)] [RED("ticketNames", 2,0)] 		public CArray<CName> TicketNames { get; set;}

		public CR4PlayerStateCombat(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4PlayerStateCombat(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}