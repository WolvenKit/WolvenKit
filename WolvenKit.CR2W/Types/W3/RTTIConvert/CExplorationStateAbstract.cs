using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExplorationStateAbstract : CScriptedComponent
	{
		[RED("m_StateNameN")] 		public CName M_StateNameN { get; set;}

		[RED("m_StateTypeE")] 		public CEnum<EExplorationStateType> M_StateTypeE { get; set;}

		[RED("m_UpdatesWhileInactiveB")] 		public CBool M_UpdatesWhileInactiveB { get; set;}

		[RED("m_ExplorationO")] 		public CHandle<CExplorationStateManager> M_ExplorationO { get; set;}

		[RED("m_LockedB")] 		public CBool M_LockedB { get; set;}

		[RED("m_ActiveB")] 		public CBool M_ActiveB { get; set;}

		[RED("m_StateNextN")] 		public CName M_StateNextN { get; set;}

		[RED("m_DefaultStateChangesArr", 2,0)] 		public CArray<SDefaultStateTransition> M_DefaultStateChangesArr { get; set;}

		[RED("m_BehaviorNeedsConfirmB")] 		public CBool M_BehaviorNeedsConfirmB { get; set;}

		[RED("m_BehaviorEventB")] 		public CBool M_BehaviorEventB { get; set;}

		[RED("m_BehaviorEventEachFrameB")] 		public CBool M_BehaviorEventEachFrameB { get; set;}

		[RED("m_BehaviorEventN")] 		public CName M_BehaviorEventN { get; set;}

		[RED("m_StateDefaultExitToN")] 		public CName M_StateDefaultExitToN { get; set;}

		[RED("m_CanReactToCriticalStateB")] 		public CBool M_CanReactToCriticalStateB { get; set;}

		[RED("m_ChangeCamerasB")] 		public CBool M_ChangeCamerasB { get; set;}

		[RED("m_CameraKeepOldB")] 		public CBool M_CameraKeepOldB { get; set;}

		[RED("m_CameraSetS")] 		public CHandle<CCameraParametersSet> M_CameraSetS { get; set;}

		[RED("m_InputContextE")] 		public CEnum<EGameplayContextInput> M_InputContextE { get; set;}

		[RED("m_TurnAdjustTimeF")] 		public CFloat M_TurnAdjustTimeF { get; set;}

		[RED("m_ActionsToBlockEArr", 2,0)] 		public CArray<CEnum<EInputActionBlock>> M_ActionsToBlockEArr { get; set;}

		[RED("m_ActionsToBlockCountI")] 		public CInt32 M_ActionsToBlockCountI { get; set;}

		[RED("m_HolsterIsFastB")] 		public CBool M_HolsterIsFastB { get; set;}

		[RED("m_CanSaveB")] 		public CBool M_CanSaveB { get; set;}

		public CExplorationStateAbstract(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CExplorationStateAbstract(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}