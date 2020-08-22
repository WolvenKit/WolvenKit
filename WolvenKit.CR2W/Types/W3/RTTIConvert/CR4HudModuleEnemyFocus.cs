using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4HudModuleEnemyFocus : CR4HudModuleBase
	{
		[RED("m_fxSetEnemyName")] 		public CHandle<CScriptedFlashFunction> M_fxSetEnemyName { get; set;}

		[RED("m_fxSetEnemyLevel")] 		public CHandle<CScriptedFlashFunction> M_fxSetEnemyLevel { get; set;}

		[RED("m_fxSetAttitude")] 		public CHandle<CScriptedFlashFunction> M_fxSetAttitude { get; set;}

		[RED("m_fxSetEnemyHealth")] 		public CHandle<CScriptedFlashFunction> M_fxSetEnemyHealth { get; set;}

		[RED("m_fxSetEnemyStamina")] 		public CHandle<CScriptedFlashFunction> M_fxSetEnemyStamina { get; set;}

		[RED("m_fxSetEssenceBarVisibility")] 		public CHandle<CScriptedFlashFunction> M_fxSetEssenceBarVisibility { get; set;}

		[RED("m_fxSetStaminaVisibility")] 		public CHandle<CScriptedFlashFunction> M_fxSetStaminaVisibility { get; set;}

		[RED("m_fxSetNPCQuestIcon")] 		public CHandle<CScriptedFlashFunction> M_fxSetNPCQuestIcon { get; set;}

		[RED("m_fxSetDodgeFeedback")] 		public CHandle<CScriptedFlashFunction> M_fxSetDodgeFeedback { get; set;}

		[RED("m_fxSetBossOrDead")] 		public CHandle<CScriptedFlashFunction> M_fxSetBossOrDead { get; set;}

		[RED("m_fxSetShowHardLock")] 		public CHandle<CScriptedFlashFunction> M_fxSetShowHardLock { get; set;}

		[RED("m_fxSetDamageText")] 		public CHandle<CScriptedFlashFunction> M_fxSetDamageText { get; set;}

		[RED("m_fxHideDamageText")] 		public CHandle<CScriptedFlashFunction> M_fxHideDamageText { get; set;}

		[RED("m_fxSetGeneralVisibility")] 		public CHandle<CScriptedFlashFunction> M_fxSetGeneralVisibility { get; set;}

		[RED("m_fxSetMutationEightVisibility")] 		public CHandle<CScriptedFlashFunction> M_fxSetMutationEightVisibility { get; set;}

		[RED("m_mcNPCFocus")] 		public CHandle<CScriptedFlashSprite> M_mcNPCFocus { get; set;}

		[RED("m_lastTarget")] 		public CHandle<CGameplayEntity> M_lastTarget { get; set;}

		[RED("m_lastTargetAttitude")] 		public CEnum<EAIAttitude> M_lastTargetAttitude { get; set;}

		[RED("m_lastHealthPercentage")] 		public CInt32 M_lastHealthPercentage { get; set;}

		[RED("m_wasAxiied")] 		public CBool M_wasAxiied { get; set;}

		[RED("m_lastStaminaPercentage")] 		public CInt32 M_lastStaminaPercentage { get; set;}

		[RED("m_nameInterval")] 		public CFloat M_nameInterval { get; set;}

		[RED("m_lastEnemyDifferenceLevel")] 		public CString M_lastEnemyDifferenceLevel { get; set;}

		[RED("m_lastEnemyLevelString")] 		public CString M_lastEnemyLevelString { get; set;}

		[RED("m_lastDodgeFeedbackTarget")] 		public CHandle<CActor> M_lastDodgeFeedbackTarget { get; set;}

		[RED("m_lastEnemyName")] 		public CString M_lastEnemyName { get; set;}

		[RED("m_lastUseMutation8Icon")] 		public CBool M_lastUseMutation8Icon { get; set;}

		public CR4HudModuleEnemyFocus(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4HudModuleEnemyFocus(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}