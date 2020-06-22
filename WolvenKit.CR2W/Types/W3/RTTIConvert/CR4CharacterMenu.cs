using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4CharacterMenu : CR4MenuBase
	{
		[RED("initDataBuySkill")] 		public CHandle<W3BuySkillConfirmation> InitDataBuySkill { get; set;}

		[RED("_playerInv")] 		public CHandle<W3GuiPlayerInventoryComponent> _playerInv { get; set;}

		[RED("_inv")] 		public CHandle<CInventoryComponent> _inv { get; set;}

		[RED("_charStatsPopupData")] 		public CHandle<CharacterStatsPopupData> _charStatsPopupData { get; set;}

		[RED("_sentStats", 2,0)] 		public CArray<SentStatsData> _sentStats { get; set;}

		[RED("currentlySelectedTab")] 		public CInt32 CurrentlySelectedTab { get; set;}

		[RED("m_previousSkillBonuses", 2,0)] 		public CArray<CString> M_previousSkillBonuses { get; set;}

		[RED("m_fxPaperdollChanged")] 		public CHandle<CScriptedFlashFunction> M_fxPaperdollChanged { get; set;}

		[RED("m_fxClearSkillSlot")] 		public CHandle<CScriptedFlashFunction> M_fxClearSkillSlot { get; set;}

		[RED("m_fxNotifySkillUpgraded")] 		public CHandle<CScriptedFlashFunction> M_fxNotifySkillUpgraded { get; set;}

		[RED("m_fxActivateRunwordBuf")] 		public CHandle<CScriptedFlashFunction> M_fxActivateRunwordBuf { get; set;}

		[RED("m_fxSetMutationBonusMode")] 		public CHandle<CScriptedFlashFunction> M_fxSetMutationBonusMode { get; set;}

		[RED("m_fxConfirmMutResearch")] 		public CHandle<CScriptedFlashFunction> M_fxConfirmMutResearch { get; set;}

		[RED("m_fxResetInput")] 		public CHandle<CScriptedFlashFunction> M_fxResetInput { get; set;}

		[RED("m_fxSetMasterMutationBackgroundColor")] 		public CHandle<CScriptedFlashFunction> M_fxSetMasterMutationBackgroundColor { get; set;}

		[RED("m_fxSetMasterMutationOverlayColor")] 		public CHandle<CScriptedFlashFunction> M_fxSetMasterMutationOverlayColor { get; set;}

		[RED("m_fxSetConnectorsColors")] 		public CHandle<CScriptedFlashFunction> M_fxSetConnectorsColors { get; set;}

		[RED("m_mutationBonusMode")] 		public CBool M_mutationBonusMode { get; set;}

		[RED("MAX_BONUS_SOCKETS")] 		public CInt32 MAX_BONUS_SOCKETS { get; set;}

		[RED("MAX_MASTER_MUTATION_STAGE")] 		public CInt32 MAX_MASTER_MUTATION_STAGE { get; set;}

		public CR4CharacterMenu(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4CharacterMenu(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}