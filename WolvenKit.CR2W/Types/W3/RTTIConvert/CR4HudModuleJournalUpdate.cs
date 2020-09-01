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
		[Ordinal(1)] [RED("("_bDuringDisplay")] 		public CBool _bDuringDisplay { get; set;}

		[Ordinal(2)] [RED("("m_fxShowJournalUpdateSFF")] 		public CHandle<CScriptedFlashFunction> M_fxShowJournalUpdateSFF { get; set;}

		[Ordinal(3)] [RED("("m_fxSetJournalUpdateStatusSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetJournalUpdateStatusSFF { get; set;}

		[Ordinal(4)] [RED("("m_fxSetJournalUpdateStatusTextSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetJournalUpdateStatusTextSFF { get; set;}

		[Ordinal(5)] [RED("("m_fxClearJournalUpdateSFF")] 		public CHandle<CScriptedFlashFunction> M_fxClearJournalUpdateSFF { get; set;}

		[Ordinal(6)] [RED("("m_fxSetIconSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetIconSFF { get; set;}

		[Ordinal(7)] [RED("("m_fxHideItemInfo")] 		public CHandle<CScriptedFlashFunction> M_fxHideItemInfo { get; set;}

		[Ordinal(8)] [RED("("m_fxPauseShowTimer")] 		public CHandle<CScriptedFlashFunction> M_fxPauseShowTimer { get; set;}

		[Ordinal(9)] [RED("("questsUpdates", 2,0)] 		public CArray<CHandle<CJournalQuest>> QuestsUpdates { get; set;}

		[Ordinal(10)] [RED("("journalUpdates", 2,0)] 		public CArray<SJournalUpdate> JournalUpdates { get; set;}

		[Ordinal(11)] [RED("("manager")] 		public CHandle<CWitcherJournalManager> Manager { get; set;}

		[Ordinal(12)] [RED("("m_guiManager")] 		public CHandle<CR4GuiManager> M_guiManager { get; set;}

		[Ordinal(13)] [RED("("m_flashValueStorage")] 		public CHandle<CScriptedFlashValueStorage> M_flashValueStorage { get; set;}

		[Ordinal(14)] [RED("("m_defaultInputBindings", 2,0)] 		public CArray<SKeyBinding> M_defaultInputBindings { get; set;}

		[Ordinal(15)] [RED("("m_bookItemId")] 		public SItemUniqueId M_bookItemId { get; set;}

		[Ordinal(16)] [RED("("m_bookPopupData")] 		public CHandle<BookPopupFeedback> M_bookPopupData { get; set;}

		[Ordinal(17)] [RED("("m_paintingPopupData")] 		public CHandle<PaintingPopup> M_paintingPopupData { get; set;}

		[Ordinal(18)] [RED("("bShowTimerStopped")] 		public CBool BShowTimerStopped { get; set;}

		[Ordinal(19)] [RED("("bWasRemoved")] 		public CBool BWasRemoved { get; set;}

		[Ordinal(20)] [RED("("defaultDisplayTime")] 		public CFloat DefaultDisplayTime { get; set;}

		[Ordinal(21)] [RED("("defaultBookInfoDisplayTime")] 		public CFloat DefaultBookInfoDisplayTime { get; set;}

		[Ordinal(22)] [RED("("defaultTrackableDisplayTime")] 		public CFloat DefaultTrackableDisplayTime { get; set;}

		public CR4HudModuleJournalUpdate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4HudModuleJournalUpdate(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}