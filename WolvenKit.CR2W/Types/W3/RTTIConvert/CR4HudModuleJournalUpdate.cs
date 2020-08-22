using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4HudModuleJournalUpdate : CR4HudModuleBase
	{
		[RED("_bDuringDisplay")] 		public CBool _bDuringDisplay { get; set;}

		[RED("m_fxShowJournalUpdateSFF")] 		public CHandle<CScriptedFlashFunction> M_fxShowJournalUpdateSFF { get; set;}

		[RED("m_fxSetJournalUpdateStatusSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetJournalUpdateStatusSFF { get; set;}

		[RED("m_fxSetJournalUpdateStatusTextSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetJournalUpdateStatusTextSFF { get; set;}

		[RED("m_fxClearJournalUpdateSFF")] 		public CHandle<CScriptedFlashFunction> M_fxClearJournalUpdateSFF { get; set;}

		[RED("m_fxSetIconSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetIconSFF { get; set;}

		[RED("m_fxHideItemInfo")] 		public CHandle<CScriptedFlashFunction> M_fxHideItemInfo { get; set;}

		[RED("m_fxPauseShowTimer")] 		public CHandle<CScriptedFlashFunction> M_fxPauseShowTimer { get; set;}

		[RED("questsUpdates", 2,0)] 		public CArray<CHandle<CJournalQuest>> QuestsUpdates { get; set;}

		[RED("journalUpdates", 2,0)] 		public CArray<SJournalUpdate> JournalUpdates { get; set;}

		[RED("manager")] 		public CHandle<CWitcherJournalManager> Manager { get; set;}

		[RED("m_guiManager")] 		public CHandle<CR4GuiManager> M_guiManager { get; set;}

		[RED("m_flashValueStorage")] 		public CHandle<CScriptedFlashValueStorage> M_flashValueStorage { get; set;}

		[RED("m_defaultInputBindings", 2,0)] 		public CArray<SKeyBinding> M_defaultInputBindings { get; set;}

		[RED("m_bookItemId")] 		public SItemUniqueId M_bookItemId { get; set;}

		[RED("m_bookPopupData")] 		public CHandle<BookPopupFeedback> M_bookPopupData { get; set;}

		[RED("m_paintingPopupData")] 		public CHandle<PaintingPopup> M_paintingPopupData { get; set;}

		[RED("bShowTimerStopped")] 		public CBool BShowTimerStopped { get; set;}

		[RED("bWasRemoved")] 		public CBool BWasRemoved { get; set;}

		[RED("defaultDisplayTime")] 		public CFloat DefaultDisplayTime { get; set;}

		[RED("defaultBookInfoDisplayTime")] 		public CFloat DefaultBookInfoDisplayTime { get; set;}

		[RED("defaultTrackableDisplayTime")] 		public CFloat DefaultTrackableDisplayTime { get; set;}

		public CR4HudModuleJournalUpdate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4HudModuleJournalUpdate(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}