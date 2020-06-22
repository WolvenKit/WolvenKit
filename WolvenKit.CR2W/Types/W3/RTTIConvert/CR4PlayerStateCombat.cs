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
		[RED("comboDefinition")] 		public CHandle<CComboDefinition> ComboDefinition { get; set;}

		[RED("comboPlayer")] 		public CHandle<CComboPlayer> ComboPlayer { get; set;}

		[RED("updatePosition")] 		public CBool UpdatePosition { get; set;}

		[RED("bIsSwitchingDirection")] 		public CBool BIsSwitchingDirection { get; set;}

		[RED("currentWeapon")] 		public CEnum<EPlayerWeapon> CurrentWeapon { get; set;}

		[RED("comboAttackA_Id")] 		public CInt32 ComboAttackA_Id { get; set;}

		[RED("comboAttackA_Target")] 		public CHandle<CGameplayEntity> ComboAttackA_Target { get; set;}

		[RED("comboAttackA_Sliding")] 		public CBool ComboAttackA_Sliding { get; set;}

		[RED("comboAttackB_Id")] 		public CInt32 ComboAttackB_Id { get; set;}

		[RED("comboAttackB_Target")] 		public CHandle<CGameplayEntity> ComboAttackB_Target { get; set;}

		[RED("comboAttackB_Sliding")] 		public CBool ComboAttackB_Sliding { get; set;}

		[RED("comboAspectName")] 		public CName ComboAspectName { get; set;}

		[RED("enemiesInRange", 2,0)] 		public CArray<CHandle<CActor>> EnemiesInRange { get; set;}

		[RED("positionWeightsDest", 2,0)] 		public CArray<CFloat> PositionWeightsDest { get; set;}

		[RED("positionWeights", 2,0)] 		public CArray<CFloat> PositionWeights { get; set;}

		[RED("positionVelocity", 2,0)] 		public CArray<CFloat> PositionVelocity { get; set;}

		[RED("positionWeightDamper")] 		public CHandle<SpringDamper> PositionWeightDamper { get; set;}

		[RED("dodgeDirection")] 		public CEnum<EPlayerEvadeDirection> DodgeDirection { get; set;}

		[RED("zoomOutForApproachingAttacker")] 		public CBool ZoomOutForApproachingAttacker { get; set;}

		[RED("slideDistanceOffset")] 		public CFloat SlideDistanceOffset { get; set;}

		[RED("startupAction")] 		public CEnum<EInitialAction> StartupAction { get; set;}

		[RED("startupBuff")] 		public CHandle<CBaseGameplayEffect> StartupBuff { get; set;}

		[RED("isInCriticalState")] 		public CBool IsInCriticalState { get; set;}

		[RED("realCombat")] 		public CBool RealCombat { get; set;}

		[RED("lastVitality")] 		public CFloat LastVitality { get; set;}

		[RED("timeToCheckCombatEndCur")] 		public CFloat TimeToCheckCombatEndCur { get; set;}

		[RED("timeToCheckCombatEndMax")] 		public CFloat TimeToCheckCombatEndMax { get; set;}

		[RED("timeToExitCombatFromSprinting")] 		public CFloat TimeToExitCombatFromSprinting { get; set;}

		[RED("cFMCameraZoomIsEnabled")] 		public CBool CFMCameraZoomIsEnabled { get; set;}

		[RED("cachedStance")] 		public CEnum<EPlayerCombatStance> CachedStance { get; set;}

		[RED("disableCombatStanceTimer")] 		public CBool DisableCombatStanceTimer { get; set;}

		[RED("evadeTarget")] 		public CHandle<CActor> EvadeTarget { get; set;}

		[RED("wasLockedToTarget")] 		public CBool WasLockedToTarget { get; set;}

		[RED("angle")] 		public CFloat Angle { get; set;}

		[RED("cachedDodgeDirection")] 		public CEnum<EPlayerEvadeDirection> CachedDodgeDirection { get; set;}

		[RED("prevRawLeftJoyRot")] 		public CFloat PrevRawLeftJoyRot { get; set;}

		[RED("evadeTargetPos")] 		public Vector EvadeTargetPos { get; set;}

		[RED("cachedRawDodgeHeading")] 		public CFloat CachedRawDodgeHeading { get; set;}

		[RED("turnInPlaceBeforeDodge")] 		public CBool TurnInPlaceBeforeDodge { get; set;}

		[RED("dodgePlaylistFwd", 2,0)] 		public CArray<CFloat> DodgePlaylistFwd { get; set;}

		[RED("dodgePlaylistFlipFwd", 2,0)] 		public CArray<CFloat> DodgePlaylistFlipFwd { get; set;}

		[RED("dodgePlaylistBck", 2,0)] 		public CArray<CFloat> DodgePlaylistBck { get; set;}

		[RED("cachedPlayerAttackType")] 		public CName CachedPlayerAttackType { get; set;}

		[RED("farAttackMinDist")] 		public CFloat FarAttackMinDist { get; set;}

		[RED("previousSlideTarget")] 		public CHandle<CGameplayEntity> PreviousSlideTarget { get; set;}

		[RED("finisherDist")] 		public CFloat FinisherDist { get; set;}

		[RED("isOnHighSlope")] 		public CBool IsOnHighSlope { get; set;}

		[RED("prevPlayerToTargetDist")] 		public CFloat PrevPlayerToTargetDist { get; set;}

		[RED("wasDecreasing")] 		public CBool WasDecreasing { get; set;}

		[RED("enableSoftLock")] 		public CBool EnableSoftLock { get; set;}

		[RED("wasInCloseCombat")] 		public CBool WasInCloseCombat { get; set;}

		[RED("ticketRequests", 2,0)] 		public CArray<CInt32> TicketRequests { get; set;}

		[RED("ticketNames", 2,0)] 		public CArray<CName> TicketNames { get; set;}

		public CR4PlayerStateCombat(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4PlayerStateCombat(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}