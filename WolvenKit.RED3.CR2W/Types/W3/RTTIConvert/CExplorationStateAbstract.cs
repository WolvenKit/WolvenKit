using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExplorationStateAbstract : CScriptedComponent
	{
		[Ordinal(1)] [RED("m_StateNameN")] 		public CName M_StateNameN { get; set;}

		[Ordinal(2)] [RED("m_StateTypeE")] 		public CEnum<EExplorationStateType> M_StateTypeE { get; set;}

		[Ordinal(3)] [RED("m_UpdatesWhileInactiveB")] 		public CBool M_UpdatesWhileInactiveB { get; set;}

		[Ordinal(4)] [RED("m_ExplorationO")] 		public CHandle<CExplorationStateManager> M_ExplorationO { get; set;}

		[Ordinal(5)] [RED("m_LockedB")] 		public CBool M_LockedB { get; set;}

		[Ordinal(6)] [RED("m_ActiveB")] 		public CBool M_ActiveB { get; set;}

		[Ordinal(7)] [RED("m_StateNextN")] 		public CName M_StateNextN { get; set;}

		[Ordinal(8)] [RED("m_DefaultStateChangesArr", 2,0)] 		public CArray<SDefaultStateTransition> M_DefaultStateChangesArr { get; set;}

		[Ordinal(9)] [RED("m_BehaviorNeedsConfirmB")] 		public CBool M_BehaviorNeedsConfirmB { get; set;}

		[Ordinal(10)] [RED("m_BehaviorEventB")] 		public CBool M_BehaviorEventB { get; set;}

		[Ordinal(11)] [RED("m_BehaviorEventEachFrameB")] 		public CBool M_BehaviorEventEachFrameB { get; set;}

		[Ordinal(12)] [RED("m_BehaviorEventN")] 		public CName M_BehaviorEventN { get; set;}

		[Ordinal(13)] [RED("m_StateDefaultExitToN")] 		public CName M_StateDefaultExitToN { get; set;}

		[Ordinal(14)] [RED("m_CanReactToCriticalStateB")] 		public CBool M_CanReactToCriticalStateB { get; set;}

		[Ordinal(15)] [RED("m_ChangeCamerasB")] 		public CBool M_ChangeCamerasB { get; set;}

		[Ordinal(16)] [RED("m_CameraKeepOldB")] 		public CBool M_CameraKeepOldB { get; set;}

		[Ordinal(17)] [RED("m_CameraSetS")] 		public CHandle<CCameraParametersSet> M_CameraSetS { get; set;}

		[Ordinal(18)] [RED("m_InputContextE")] 		public CEnum<EGameplayContextInput> M_InputContextE { get; set;}

		[Ordinal(19)] [RED("m_TurnAdjustTimeF")] 		public CFloat M_TurnAdjustTimeF { get; set;}

		[Ordinal(20)] [RED("m_ActionsToBlockEArr", 2,0)] 		public CArray<CEnum<EInputActionBlock>> M_ActionsToBlockEArr { get; set;}

		[Ordinal(21)] [RED("m_ActionsToBlockCountI")] 		public CInt32 M_ActionsToBlockCountI { get; set;}

		[Ordinal(22)] [RED("m_HolsterIsFastB")] 		public CBool M_HolsterIsFastB { get; set;}

		[Ordinal(23)] [RED("m_CanSaveB")] 		public CBool M_CanSaveB { get; set;}

		public CExplorationStateAbstract(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CExplorationStateAbstract(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}