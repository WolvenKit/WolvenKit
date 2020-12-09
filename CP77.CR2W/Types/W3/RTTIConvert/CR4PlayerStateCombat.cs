using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4PlayerStateCombat : CR4PlayerStateExtendedMovable
	{
		[Ordinal(1)] [RED("comboDefinition")] 		public CHandle<CComboDefinition> ComboDefinition { get; set;}

		[Ordinal(2)] [RED("comboPlayer")] 		public CHandle<CComboPlayer> ComboPlayer { get; set;}

		[Ordinal(3)] [RED("updatePosition")] 		public CBool UpdatePosition { get; set;}

		[Ordinal(4)] [RED("bIsSwitchingDirection")] 		public CBool BIsSwitchingDirection { get; set;}

		[Ordinal(5)] [RED("currentWeapon")] 		public CEnum<EPlayerWeapon> CurrentWeapon { get; set;}

		[Ordinal(6)] [RED("comboAttackA_Id")] 		public CInt32 ComboAttackA_Id { get; set;}

		[Ordinal(7)] [RED("comboAttackA_Target")] 		public CHandle<CGameplayEntity> ComboAttackA_Target { get; set;}

		[Ordinal(8)] [RED("comboAttackA_Sliding")] 		public CBool ComboAttackA_Sliding { get; set;}

		[Ordinal(9)] [RED("comboAttackB_Id")] 		public CInt32 ComboAttackB_Id { get; set;}

		[Ordinal(10)] [RED("comboAttackB_Target")] 		public CHandle<CGameplayEntity> ComboAttackB_Target { get; set;}

		[Ordinal(11)] [RED("comboAttackB_Sliding")] 		public CBool ComboAttackB_Sliding { get; set;}

		[Ordinal(12)] [RED("comboAspectName")] 		public CName ComboAspectName { get; set;}

		[Ordinal(13)] [RED("enemiesInRange", 2,0)] 		public CArray<CHandle<CActor>> EnemiesInRange { get; set;}

		[Ordinal(14)] [RED("positionWeightsDest", 2,0)] 		public CArray<CFloat> PositionWeightsDest { get; set;}

		[Ordinal(15)] [RED("positionWeights", 2,0)] 		public CArray<CFloat> PositionWeights { get; set;}

		[Ordinal(16)] [RED("positionVelocity", 2,0)] 		public CArray<CFloat> PositionVelocity { get; set;}

		[Ordinal(17)] [RED("positionWeightDamper")] 		public CHandle<SpringDamper> PositionWeightDamper { get; set;}

		[Ordinal(18)] [RED("dodgeDirection")] 		public CEnum<EPlayerEvadeDirection> DodgeDirection { get; set;}

		[Ordinal(19)] [RED("zoomOutForApproachingAttacker")] 		public CBool ZoomOutForApproachingAttacker { get; set;}

		[Ordinal(20)] [RED("slideDistanceOffset")] 		public CFloat SlideDistanceOffset { get; set;}

		[Ordinal(21)] [RED("startupAction")] 		public CEnum<EInitialAction> StartupAction { get; set;}

		[Ordinal(22)] [RED("startupBuff")] 		public CHandle<CBaseGameplayEffect> StartupBuff { get; set;}

		[Ordinal(23)] [RED("isInCriticalState")] 		public CBool IsInCriticalState { get; set;}

		[Ordinal(24)] [RED("realCombat")] 		public CBool RealCombat { get; set;}

		[Ordinal(25)] [RED("lastVitality")] 		public CFloat LastVitality { get; set;}

		[Ordinal(26)] [RED("timeToCheckCombatEndCur")] 		public CFloat TimeToCheckCombatEndCur { get; set;}

		[Ordinal(27)] [RED("timeToCheckCombatEndMax")] 		public CFloat TimeToCheckCombatEndMax { get; set;}

		[Ordinal(28)] [RED("timeToExitCombatFromSprinting")] 		public CFloat TimeToExitCombatFromSprinting { get; set;}

		[Ordinal(29)] [RED("cFMCameraZoomIsEnabled")] 		public CBool CFMCameraZoomIsEnabled { get; set;}

		[Ordinal(30)] [RED("cachedStance")] 		public CEnum<EPlayerCombatStance> CachedStance { get; set;}

		[Ordinal(31)] [RED("disableCombatStanceTimer")] 		public CBool DisableCombatStanceTimer { get; set;}

		[Ordinal(32)] [RED("evadeTarget")] 		public CHandle<CActor> EvadeTarget { get; set;}

		[Ordinal(33)] [RED("wasLockedToTarget")] 		public CBool WasLockedToTarget { get; set;}

		[Ordinal(34)] [RED("angle")] 		public CFloat Angle { get; set;}

		[Ordinal(35)] [RED("cachedDodgeDirection")] 		public CEnum<EPlayerEvadeDirection> CachedDodgeDirection { get; set;}

		[Ordinal(36)] [RED("prevRawLeftJoyRot")] 		public CFloat PrevRawLeftJoyRot { get; set;}

		[Ordinal(37)] [RED("evadeTargetPos")] 		public Vector EvadeTargetPos { get; set;}

		[Ordinal(38)] [RED("cachedRawDodgeHeading")] 		public CFloat CachedRawDodgeHeading { get; set;}

		[Ordinal(39)] [RED("turnInPlaceBeforeDodge")] 		public CBool TurnInPlaceBeforeDodge { get; set;}

		[Ordinal(40)] [RED("dodgePlaylistFwd", 2,0)] 		public CArray<CFloat> DodgePlaylistFwd { get; set;}

		[Ordinal(41)] [RED("dodgePlaylistFlipFwd", 2,0)] 		public CArray<CFloat> DodgePlaylistFlipFwd { get; set;}

		[Ordinal(42)] [RED("dodgePlaylistBck", 2,0)] 		public CArray<CFloat> DodgePlaylistBck { get; set;}

		[Ordinal(43)] [RED("cachedPlayerAttackType")] 		public CName CachedPlayerAttackType { get; set;}

		[Ordinal(44)] [RED("farAttackMinDist")] 		public CFloat FarAttackMinDist { get; set;}

		[Ordinal(45)] [RED("previousSlideTarget")] 		public CHandle<CGameplayEntity> PreviousSlideTarget { get; set;}

		[Ordinal(46)] [RED("finisherDist")] 		public CFloat FinisherDist { get; set;}

		[Ordinal(47)] [RED("isOnHighSlope")] 		public CBool IsOnHighSlope { get; set;}

		[Ordinal(48)] [RED("prevPlayerToTargetDist")] 		public CFloat PrevPlayerToTargetDist { get; set;}

		[Ordinal(49)] [RED("wasDecreasing")] 		public CBool WasDecreasing { get; set;}

		[Ordinal(50)] [RED("enableSoftLock")] 		public CBool EnableSoftLock { get; set;}

		[Ordinal(51)] [RED("wasInCloseCombat")] 		public CBool WasInCloseCombat { get; set;}

		[Ordinal(52)] [RED("ticketRequests", 2,0)] 		public CArray<CInt32> TicketRequests { get; set;}

		[Ordinal(53)] [RED("ticketNames", 2,0)] 		public CArray<CName> TicketNames { get; set;}

		public CR4PlayerStateCombat(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4PlayerStateCombat(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}