using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExplorationStateManager : CSelfUpdatingComponent
	{
		[Ordinal(0)] [RED("m_OwnerE")] 		public CHandle<CGameplayEntity> M_OwnerE { get; set;}

		[Ordinal(0)] [RED("m_OwnerMAC")] 		public CHandle<CMovingPhysicalAgentComponent> M_OwnerMAC { get; set;}

		[Ordinal(0)] [RED("m_InputO")] 		public CHandle<CExplorationInput> M_InputO { get; set;}

		[Ordinal(0)] [RED("m_MoverO")] 		public CHandle<CExplorationMover> M_MoverO { get; set;}

		[Ordinal(0)] [RED("m_SharedDataO")] 		public CHandle<CExplorationSharedData> M_SharedDataO { get; set;}

		[Ordinal(0)] [RED("m_CollisionManagerO")] 		public CHandle<CExplorationCollisionManager> M_CollisionManagerO { get; set;}

		[Ordinal(0)] [RED("m_MovementCorrectorO")] 		public CHandle<CExplorationMovementCorrector> M_MovementCorrectorO { get; set;}

		[Ordinal(0)] [RED("m_SuperStateLastN")] 		public CName M_SuperStateLastN { get; set;}

		[Ordinal(0)] [RED("m_StatesSArr", 2,0)] 		public CArray<CHandle<CExplorationStateAbstract>> M_StatesSArr { get; set;}

		[Ordinal(0)] [RED("m_StatesUpdatedInactiveSArr", 2,0)] 		public CArray<CHandle<CExplorationStateAbstract>> M_StatesUpdatedInactiveSArr { get; set;}

		[Ordinal(0)] [RED("m_StateNamesSArr", 2,0)] 		public CArray<CName> M_StateNamesSArr { get; set;}

		[Ordinal(0)] [RED("m_StateTransitionsSArr", 2,0)] 		public CArray<CHandle<CExplorationStateTransitionAbstract>> M_StateTransitionsSArr { get; set;}

		[Ordinal(0)] [RED("m_StateLastN")] 		public CName M_StateLastN { get; set;}

		[Ordinal(0)] [RED("m_StateLastI")] 		public CInt32 M_StateLastI { get; set;}

		[Ordinal(0)] [RED("m_StateCurN")] 		public CName M_StateCurN { get; set;}

		[Ordinal(0)] [RED("m_StateCurI")] 		public CInt32 M_StateCurI { get; set;}

		[Ordinal(0)] [RED("m_StateTimeCurF")] 		public CFloat M_StateTimeCurF { get; set;}

		[Ordinal(0)] [RED("m_StateTimeLastF")] 		public CFloat M_StateTimeLastF { get; set;}

		[Ordinal(0)] [RED("m_StateGlobalQueuedN")] 		public CName M_StateGlobalQueuedN { get; set;}

		[Ordinal(0)] [RED("m_StateDefaultN")] 		public CName M_StateDefaultN { get; set;}

		[Ordinal(0)] [RED("c_InvalidStateN")] 		public CName C_InvalidStateN { get; set;}

		[Ordinal(0)] [RED("c_InvalidStateI")] 		public CInt32 C_InvalidStateI { get; set;}

		[Ordinal(0)] [RED("m_StateChanged")] 		public CBool M_StateChanged { get; set;}

		[Ordinal(0)] [RED("m_StateExitedFromBehN")] 		public CName M_StateExitedFromBehN { get; set;}

		[Ordinal(0)] [RED("m_StateEnteredFromBehN")] 		public CName M_StateEnteredFromBehN { get; set;}

		[Ordinal(0)] [RED("m_BehaviorConfirmStateE")] 		public CEnum<EBehGraphConfirmationState> M_BehaviorConfirmStateE { get; set;}

		[Ordinal(0)] [RED("m_StateBehCurReportedN")] 		public CName M_StateBehCurReportedN { get; set;}

		[Ordinal(0)] [RED("m_DefaultCameraSetS")] 		public CHandle<CCameraParametersSet> M_DefaultCameraSetS { get; set;}

		[Ordinal(0)] [RED("m_IsOnGroundB")] 		public CBool M_IsOnGroundB { get; set;}

		[Ordinal(0)] [RED("m_TeleportedFallHackTime")] 		public CFloat M_TeleportedFallHackTime { get; set;}

		[Ordinal(0)] [RED("m_TeleportedFallHackTimeTotalF")] 		public CFloat M_TeleportedFallHackTimeTotalF { get; set;}

		[Ordinal(0)] [RED("m_storedInteractionPri")] 		public CEnum<EInteractionPriority> M_storedInteractionPri { get; set;}

		[Ordinal(0)] [RED("m_NoSaveLock")] 		public CInt32 M_NoSaveLock { get; set;}

		[Ordinal(0)] [RED("m_NoSaveLockStringS")] 		public CString M_NoSaveLockStringS { get; set;}

		[Ordinal(0)] [RED("m_ActiveB")] 		public CBool M_ActiveB { get; set;}

		[Ordinal(0)] [RED("m_InitializedB")] 		public CBool M_InitializedB { get; set;}

		[Ordinal(0)] [RED("m_IsDebugModeB")] 		public CBool M_IsDebugModeB { get; set;}

		[Ordinal(0)] [RED("m_DebugPointV")] 		public Vector M_DebugPointV { get; set;}

		[Ordinal(0)] [RED("m_SmoothedVelocityV")] 		public Vector M_SmoothedVelocityV { get; set;}

		public CExplorationStateManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CExplorationStateManager(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}