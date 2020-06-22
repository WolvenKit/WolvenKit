using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4HudModuleInteractions : CR4HudModuleBase
	{
		[RED("bShowHoldIndicator")] 		public CBool BShowHoldIndicator { get; set;}

		[RED("bShowInteraction")] 		public CBool BShowInteraction { get; set;}

		[RED("bShowFocusInteractions")] 		public CBool BShowFocusInteractions { get; set;}

		[RED("m_fxDisableHoldIndicator")] 		public CHandle<CScriptedFlashFunction> M_fxDisableHoldIndicator { get; set;}

		[RED("m_fxEnableHoldIndicator")] 		public CHandle<CScriptedFlashFunction> M_fxEnableHoldIndicator { get; set;}

		[RED("m_fxSetInteractionKeySFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetInteractionKeySFF { get; set;}

		[RED("m_fxSetInteractionIconSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetInteractionIconSFF { get; set;}

		[RED("m_fxSetInteractionTextSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetInteractionTextSFF { get; set;}

		[RED("m_fxSetInteractionIconAndTextSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetInteractionIconAndTextSFF { get; set;}

		[RED("m_fxSetInteractionKeyIconAndTextSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetInteractionKeyIconAndTextSFF { get; set;}

		[RED("m_fxAddFocusInteractionIconSFF")] 		public CHandle<CScriptedFlashFunction> M_fxAddFocusInteractionIconSFF { get; set;}

		[RED("m_fxSetInteractionHoldDuration")] 		public CHandle<CScriptedFlashFunction> M_fxSetInteractionHoldDuration { get; set;}

		[RED("m_fxRemoveFocusInteractionIconSFF")] 		public CHandle<CScriptedFlashFunction> M_fxRemoveFocusInteractionIconSFF { get; set;}

		[RED("m_fxUpdateFocusInteractionIconPositionSFF")] 		public CHandle<CScriptedFlashFunction> M_fxUpdateFocusInteractionIconPositionSFF { get; set;}

		[RED("m_fxSetVisibilitySFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetVisibilitySFF { get; set;}

		[RED("m_fxSetVisibilityExSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetVisibilityExSFF { get; set;}

		[RED("m_fxSetPositionsSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetPositionsSFF { get; set;}

		[RED("_interactionEntity")] 		public CHandle<CGameplayEntity> _interactionEntity { get; set;}

		[RED("_interactionEntityComponent")] 		public CHandle<CInteractionComponent> _interactionEntityComponent { get; set;}

		[RED("m_focusInteractionIcons", 2,0)] 		public CArray<SFocusInteractionIcon> M_focusInteractionIcons { get; set;}

		[RED("m_previouslyShow")] 		public CBool M_previouslyShow { get; set;}

		[RED("m_previousInteractionEntity")] 		public CHandle<CGameplayEntity> M_previousInteractionEntity { get; set;}

		[RED("m_previousDisplayEntity")] 		public CHandle<CGameplayEntity> M_previousDisplayEntity { get; set;}

		[RED("m_previousDisplayEntityDataRet")] 		public CBool M_previousDisplayEntityDataRet { get; set;}

		[RED("m_forceUpdate")] 		public CBool M_forceUpdate { get; set;}

		[RED("m_currentHoldInteraction")] 		public CName M_currentHoldInteraction { get; set;}

		[RED("FOCUS_INTERACION_UPDATE_INTERVAL")] 		public CFloat FOCUS_INTERACION_UPDATE_INTERVAL { get; set;}

		[RED("FOCUS_INTERACION_RADIUS")] 		public CFloat FOCUS_INTERACION_RADIUS { get; set;}

		[RED("FOCUS_INTERACTION_OPAQUE_ICON_RADIUS")] 		public CFloat FOCUS_INTERACTION_OPAQUE_ICON_RADIUS { get; set;}

		[RED("FOCUS_INTERACTION_TRANSPARENT_ICON_RADIUS")] 		public CFloat FOCUS_INTERACTION_TRANSPARENT_ICON_RADIUS { get; set;}

		public CR4HudModuleInteractions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4HudModuleInteractions(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}