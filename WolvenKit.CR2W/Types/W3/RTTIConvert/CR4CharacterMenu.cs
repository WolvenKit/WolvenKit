using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4CharacterMenu : CR4MenuBase
	{
		[Ordinal(1)] [RED("initDataBuySkill")] 		public CHandle<W3BuySkillConfirmation> InitDataBuySkill { get; set;}

		[Ordinal(2)] [RED("_playerInv")] 		public CHandle<W3GuiPlayerInventoryComponent> _playerInv { get; set;}

		[Ordinal(3)] [RED("_inv")] 		public CHandle<CInventoryComponent> _inv { get; set;}

		[Ordinal(4)] [RED("_charStatsPopupData")] 		public CHandle<CharacterStatsPopupData> _charStatsPopupData { get; set;}

		[Ordinal(5)] [RED("_sentStats", 2,0)] 		public CArray<SentStatsData> _sentStats { get; set;}

		[Ordinal(6)] [RED("currentlySelectedTab")] 		public CInt32 CurrentlySelectedTab { get; set;}

		[Ordinal(7)] [RED("m_previousSkillBonuses", 2,0)] 		public CArray<CString> M_previousSkillBonuses { get; set;}

		[Ordinal(8)] [RED("m_fxPaperdollChanged")] 		public CHandle<CScriptedFlashFunction> M_fxPaperdollChanged { get; set;}

		[Ordinal(9)] [RED("m_fxClearSkillSlot")] 		public CHandle<CScriptedFlashFunction> M_fxClearSkillSlot { get; set;}

		[Ordinal(10)] [RED("m_fxNotifySkillUpgraded")] 		public CHandle<CScriptedFlashFunction> M_fxNotifySkillUpgraded { get; set;}

		[Ordinal(11)] [RED("m_fxActivateRunwordBuf")] 		public CHandle<CScriptedFlashFunction> M_fxActivateRunwordBuf { get; set;}

		[Ordinal(12)] [RED("m_fxSetMutationBonusMode")] 		public CHandle<CScriptedFlashFunction> M_fxSetMutationBonusMode { get; set;}

		[Ordinal(13)] [RED("m_fxConfirmMutResearch")] 		public CHandle<CScriptedFlashFunction> M_fxConfirmMutResearch { get; set;}

		[Ordinal(14)] [RED("m_fxResetInput")] 		public CHandle<CScriptedFlashFunction> M_fxResetInput { get; set;}

		[Ordinal(15)] [RED("m_fxSetMasterMutationBackgroundColor")] 		public CHandle<CScriptedFlashFunction> M_fxSetMasterMutationBackgroundColor { get; set;}

		[Ordinal(16)] [RED("m_fxSetMasterMutationOverlayColor")] 		public CHandle<CScriptedFlashFunction> M_fxSetMasterMutationOverlayColor { get; set;}

		[Ordinal(17)] [RED("m_fxSetConnectorsColors")] 		public CHandle<CScriptedFlashFunction> M_fxSetConnectorsColors { get; set;}

		[Ordinal(18)] [RED("m_mutationBonusMode")] 		public CBool M_mutationBonusMode { get; set;}

		[Ordinal(19)] [RED("MAX_BONUS_SOCKETS")] 		public CInt32 MAX_BONUS_SOCKETS { get; set;}

		[Ordinal(20)] [RED("MAX_MASTER_MUTATION_STAGE")] 		public CInt32 MAX_MASTER_MUTATION_STAGE { get; set;}

		public CR4CharacterMenu(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4CharacterMenu(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}