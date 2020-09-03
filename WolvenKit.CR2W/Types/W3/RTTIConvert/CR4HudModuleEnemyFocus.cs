using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4HudModuleEnemyFocus : CR4HudModuleBase
	{
		[Ordinal(1)] [RED("m_fxSetEnemyName")] 		public CHandle<CScriptedFlashFunction> M_fxSetEnemyName { get; set;}

		[Ordinal(2)] [RED("m_fxSetEnemyLevel")] 		public CHandle<CScriptedFlashFunction> M_fxSetEnemyLevel { get; set;}

		[Ordinal(3)] [RED("m_fxSetAttitude")] 		public CHandle<CScriptedFlashFunction> M_fxSetAttitude { get; set;}

		[Ordinal(4)] [RED("m_fxSetEnemyHealth")] 		public CHandle<CScriptedFlashFunction> M_fxSetEnemyHealth { get; set;}

		[Ordinal(5)] [RED("m_fxSetEnemyStamina")] 		public CHandle<CScriptedFlashFunction> M_fxSetEnemyStamina { get; set;}

		[Ordinal(6)] [RED("m_fxSetEssenceBarVisibility")] 		public CHandle<CScriptedFlashFunction> M_fxSetEssenceBarVisibility { get; set;}

		[Ordinal(7)] [RED("m_fxSetStaminaVisibility")] 		public CHandle<CScriptedFlashFunction> M_fxSetStaminaVisibility { get; set;}

		[Ordinal(8)] [RED("m_fxSetNPCQuestIcon")] 		public CHandle<CScriptedFlashFunction> M_fxSetNPCQuestIcon { get; set;}

		[Ordinal(9)] [RED("m_fxSetDodgeFeedback")] 		public CHandle<CScriptedFlashFunction> M_fxSetDodgeFeedback { get; set;}

		[Ordinal(10)] [RED("m_fxSetBossOrDead")] 		public CHandle<CScriptedFlashFunction> M_fxSetBossOrDead { get; set;}

		[Ordinal(11)] [RED("m_fxSetShowHardLock")] 		public CHandle<CScriptedFlashFunction> M_fxSetShowHardLock { get; set;}

		[Ordinal(12)] [RED("m_fxSetDamageText")] 		public CHandle<CScriptedFlashFunction> M_fxSetDamageText { get; set;}

		[Ordinal(13)] [RED("m_fxHideDamageText")] 		public CHandle<CScriptedFlashFunction> M_fxHideDamageText { get; set;}

		[Ordinal(14)] [RED("m_fxSetGeneralVisibility")] 		public CHandle<CScriptedFlashFunction> M_fxSetGeneralVisibility { get; set;}

		[Ordinal(15)] [RED("m_fxSetMutationEightVisibility")] 		public CHandle<CScriptedFlashFunction> M_fxSetMutationEightVisibility { get; set;}

		[Ordinal(16)] [RED("m_mcNPCFocus")] 		public CHandle<CScriptedFlashSprite> M_mcNPCFocus { get; set;}

		[Ordinal(17)] [RED("m_lastTarget")] 		public CHandle<CGameplayEntity> M_lastTarget { get; set;}

		[Ordinal(18)] [RED("m_lastTargetAttitude")] 		public CEnum<EAIAttitude> M_lastTargetAttitude { get; set;}

		[Ordinal(19)] [RED("m_lastHealthPercentage")] 		public CInt32 M_lastHealthPercentage { get; set;}

		[Ordinal(20)] [RED("m_wasAxiied")] 		public CBool M_wasAxiied { get; set;}

		[Ordinal(21)] [RED("m_lastStaminaPercentage")] 		public CInt32 M_lastStaminaPercentage { get; set;}

		[Ordinal(22)] [RED("m_nameInterval")] 		public CFloat M_nameInterval { get; set;}

		[Ordinal(23)] [RED("m_lastEnemyDifferenceLevel")] 		public CString M_lastEnemyDifferenceLevel { get; set;}

		[Ordinal(24)] [RED("m_lastEnemyLevelString")] 		public CString M_lastEnemyLevelString { get; set;}

		[Ordinal(25)] [RED("m_lastDodgeFeedbackTarget")] 		public CHandle<CActor> M_lastDodgeFeedbackTarget { get; set;}

		[Ordinal(26)] [RED("m_lastEnemyName")] 		public CString M_lastEnemyName { get; set;}

		[Ordinal(27)] [RED("m_lastUseMutation8Icon")] 		public CBool M_lastUseMutation8Icon { get; set;}

		public CR4HudModuleEnemyFocus(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4HudModuleEnemyFocus(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}