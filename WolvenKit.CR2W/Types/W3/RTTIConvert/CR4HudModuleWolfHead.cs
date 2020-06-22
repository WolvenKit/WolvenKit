using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4HudModuleWolfHead : CR4HudModuleBase
	{
		[RED("m_fxSetVitality")] 		public CHandle<CScriptedFlashFunction> M_fxSetVitality { get; set;}

		[RED("m_fxSetStamina")] 		public CHandle<CScriptedFlashFunction> M_fxSetStamina { get; set;}

		[RED("m_fxSetToxicity")] 		public CHandle<CScriptedFlashFunction> M_fxSetToxicity { get; set;}

		[RED("m_fxSetExperience")] 		public CHandle<CScriptedFlashFunction> M_fxSetExperience { get; set;}

		[RED("m_fxSetLockedToxicity")] 		public CHandle<CScriptedFlashFunction> M_fxSetLockedToxicity { get; set;}

		[RED("m_fxSetDeadlyToxicity")] 		public CHandle<CScriptedFlashFunction> M_fxSetDeadlyToxicity { get; set;}

		[RED("m_fxShowStaminaNeeded")] 		public CHandle<CScriptedFlashFunction> M_fxShowStaminaNeeded { get; set;}

		[RED("m_fxSwitchWolfActivation")] 		public CHandle<CScriptedFlashFunction> M_fxSwitchWolfActivation { get; set;}

		[RED("m_fxSetSignIconSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetSignIconSFF { get; set;}

		[RED("m_fxSetSignTextSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetSignTextSFF { get; set;}

		[RED("m_fxSetFocusPointsSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetFocusPointsSFF { get; set;}

		[RED("m_fxSetFocusProgressSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetFocusProgressSFF { get; set;}

		[RED("m_fxLockFocusPointsSFF")] 		public CHandle<CScriptedFlashFunction> M_fxLockFocusPointsSFF { get; set;}

		[RED("m_fxSetCiriAsMainCharacter")] 		public CHandle<CScriptedFlashFunction> M_fxSetCiriAsMainCharacter { get; set;}

		[RED("m_fxSetCoatOfArms")] 		public CHandle<CScriptedFlashFunction> M_fxSetCoatOfArms { get; set;}

		[RED("m_fxSetShowNewLevelIndicator")] 		public CHandle<CScriptedFlashFunction> M_fxSetShowNewLevelIndicator { get; set;}

		[RED("m_fxSetAlwaysDisplayed")] 		public CHandle<CScriptedFlashFunction> M_fxSetAlwaysDisplayed { get; set;}

		[RED("m_fxshowMutationFeedback")] 		public CHandle<CScriptedFlashFunction> M_fxshowMutationFeedback { get; set;}

		[RED("m_LastVitality")] 		public CFloat M_LastVitality { get; set;}

		[RED("m_LastMaxVitality")] 		public CFloat M_LastMaxVitality { get; set;}

		[RED("m_LastStamina")] 		public CFloat M_LastStamina { get; set;}

		[RED("m_LastMaxStamina")] 		public CFloat M_LastMaxStamina { get; set;}

		[RED("m_LastExperience")] 		public CFloat M_LastExperience { get; set;}

		[RED("m_LastMaxExperience")] 		public CFloat M_LastMaxExperience { get; set;}

		[RED("m_LastToxicity")] 		public CFloat M_LastToxicity { get; set;}

		[RED("m_LastLockedToxicity")] 		public CFloat M_LastLockedToxicity { get; set;}

		[RED("m_LastMaxToxicity")] 		public CFloat M_LastMaxToxicity { get; set;}

		[RED("m_bLastDeadlyToxicity")] 		public CBool M_bLastDeadlyToxicity { get; set;}

		[RED("m_medallionActivated")] 		public CBool M_medallionActivated { get; set;}

		[RED("m_oveloadedIconVisible")] 		public CBool M_oveloadedIconVisible { get; set;}

		[RED("m_focusPoints")] 		public CInt32 M_focusPoints { get; set;}

		[RED("m_focusProgress")] 		public CFloat M_focusProgress { get; set;}

		[RED("m_iCurrentPositiveEffectsSize")] 		public CInt32 M_iCurrentPositiveEffectsSize { get; set;}

		[RED("m_iCurrentNegativeEffectsSize")] 		public CInt32 M_iCurrentNegativeEffectsSize { get; set;}

		[RED("m_signIconName")] 		public CString M_signIconName { get; set;}

		[RED("m_CurrentSelectedSign")] 		public CEnum<ESignType> M_CurrentSelectedSign { get; set;}

		[RED("m_IsPlayerCiri")] 		public CBool M_IsPlayerCiri { get; set;}

		[RED("m_curToxicity")] 		public CFloat M_curToxicity { get; set;}

		[RED("m_lockedToxicity")] 		public CFloat M_lockedToxicity { get; set;}

		[RED("m_curVitality")] 		public CFloat M_curVitality { get; set;}

		[RED("m_maxVitality")] 		public CFloat M_maxVitality { get; set;}

		[RED("playStaminaSoundCue")] 		public CBool PlayStaminaSoundCue { get; set;}

		public CR4HudModuleWolfHead(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4HudModuleWolfHead(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}