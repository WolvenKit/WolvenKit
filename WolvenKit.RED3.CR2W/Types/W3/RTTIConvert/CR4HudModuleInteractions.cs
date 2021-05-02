using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4HudModuleInteractions : CR4HudModuleBase
	{
		[Ordinal(1)] [RED("bShowHoldIndicator")] 		public CBool BShowHoldIndicator { get; set;}

		[Ordinal(2)] [RED("bShowInteraction")] 		public CBool BShowInteraction { get; set;}

		[Ordinal(3)] [RED("bShowFocusInteractions")] 		public CBool BShowFocusInteractions { get; set;}

		[Ordinal(4)] [RED("m_fxDisableHoldIndicator")] 		public CHandle<CScriptedFlashFunction> M_fxDisableHoldIndicator { get; set;}

		[Ordinal(5)] [RED("m_fxEnableHoldIndicator")] 		public CHandle<CScriptedFlashFunction> M_fxEnableHoldIndicator { get; set;}

		[Ordinal(6)] [RED("m_fxSetInteractionKeySFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetInteractionKeySFF { get; set;}

		[Ordinal(7)] [RED("m_fxSetInteractionIconSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetInteractionIconSFF { get; set;}

		[Ordinal(8)] [RED("m_fxSetInteractionTextSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetInteractionTextSFF { get; set;}

		[Ordinal(9)] [RED("m_fxSetInteractionIconAndTextSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetInteractionIconAndTextSFF { get; set;}

		[Ordinal(10)] [RED("m_fxSetInteractionKeyIconAndTextSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetInteractionKeyIconAndTextSFF { get; set;}

		[Ordinal(11)] [RED("m_fxAddFocusInteractionIconSFF")] 		public CHandle<CScriptedFlashFunction> M_fxAddFocusInteractionIconSFF { get; set;}

		[Ordinal(12)] [RED("m_fxSetInteractionHoldDuration")] 		public CHandle<CScriptedFlashFunction> M_fxSetInteractionHoldDuration { get; set;}

		[Ordinal(13)] [RED("m_fxRemoveFocusInteractionIconSFF")] 		public CHandle<CScriptedFlashFunction> M_fxRemoveFocusInteractionIconSFF { get; set;}

		[Ordinal(14)] [RED("m_fxUpdateFocusInteractionIconPositionSFF")] 		public CHandle<CScriptedFlashFunction> M_fxUpdateFocusInteractionIconPositionSFF { get; set;}

		[Ordinal(15)] [RED("m_fxSetVisibilitySFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetVisibilitySFF { get; set;}

		[Ordinal(16)] [RED("m_fxSetVisibilityExSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetVisibilityExSFF { get; set;}

		[Ordinal(17)] [RED("m_fxSetPositionsSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetPositionsSFF { get; set;}

		[Ordinal(18)] [RED("_interactionEntity")] 		public CHandle<CGameplayEntity> _interactionEntity { get; set;}

		[Ordinal(19)] [RED("_interactionEntityComponent")] 		public CHandle<CInteractionComponent> _interactionEntityComponent { get; set;}

		[Ordinal(20)] [RED("m_focusInteractionIcons", 2,0)] 		public CArray<SFocusInteractionIcon> M_focusInteractionIcons { get; set;}

		[Ordinal(21)] [RED("m_previouslyShow")] 		public CBool M_previouslyShow { get; set;}

		[Ordinal(22)] [RED("m_previousInteractionEntity")] 		public CHandle<CGameplayEntity> M_previousInteractionEntity { get; set;}

		[Ordinal(23)] [RED("m_previousDisplayEntity")] 		public CHandle<CGameplayEntity> M_previousDisplayEntity { get; set;}

		[Ordinal(24)] [RED("m_previousDisplayEntityDataRet")] 		public CBool M_previousDisplayEntityDataRet { get; set;}

		[Ordinal(25)] [RED("m_forceUpdate")] 		public CBool M_forceUpdate { get; set;}

		[Ordinal(26)] [RED("m_currentHoldInteraction")] 		public CName M_currentHoldInteraction { get; set;}

		[Ordinal(27)] [RED("FOCUS_INTERACION_UPDATE_INTERVAL")] 		public CFloat FOCUS_INTERACION_UPDATE_INTERVAL { get; set;}

		[Ordinal(28)] [RED("FOCUS_INTERACION_RADIUS")] 		public CFloat FOCUS_INTERACION_RADIUS { get; set;}

		[Ordinal(29)] [RED("FOCUS_INTERACTION_OPAQUE_ICON_RADIUS")] 		public CFloat FOCUS_INTERACTION_OPAQUE_ICON_RADIUS { get; set;}

		[Ordinal(30)] [RED("FOCUS_INTERACTION_TRANSPARENT_ICON_RADIUS")] 		public CFloat FOCUS_INTERACTION_TRANSPARENT_ICON_RADIUS { get; set;}

		public CR4HudModuleInteractions(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4HudModuleInteractions(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}