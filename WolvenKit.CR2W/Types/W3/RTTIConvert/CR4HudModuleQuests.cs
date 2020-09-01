using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4HudModuleQuests : CR4HudModuleBase
	{
		[Ordinal(1)] [RED("("m_systemQuest")] 		public CHandle<CJournalQuest> M_systemQuest { get; set;}

		[Ordinal(2)] [RED("("m_systemObjectives", 2,0)] 		public CArray<SJournalQuestObjectiveData> M_systemObjectives { get; set;}

		[Ordinal(3)] [RED("("m_userObjectives", 2,0)] 		public CArray<SJournalQuestObjectiveData> M_userObjectives { get; set;}

		[Ordinal(4)] [RED("("m_updateEvents", 2,0)] 		public CArray<SUpdateEvent> M_updateEvents { get; set;}

		[Ordinal(5)] [RED("("manager")] 		public CHandle<CWitcherJournalManager> Manager { get; set;}

		[Ordinal(6)] [RED("("m_fxShowTrackedQuestSFF")] 		public CHandle<CScriptedFlashFunction> M_fxShowTrackedQuestSFF { get; set;}

		[Ordinal(7)] [RED("("m_fxUpdateObjectiveCounterSFF")] 		public CHandle<CScriptedFlashFunction> M_fxUpdateObjectiveCounterSFF { get; set;}

		[Ordinal(8)] [RED("("m_fxUpdateObjectiveHighlightSFF")] 		public CHandle<CScriptedFlashFunction> M_fxUpdateObjectiveHighlightSFF { get; set;}

		[Ordinal(9)] [RED("("m_fxUpdateObjectiveUnhighlightAllSFF")] 		public CHandle<CScriptedFlashFunction> M_fxUpdateObjectiveUnhighlightAllSFF { get; set;}

		[Ordinal(10)] [RED("("m_fxSetSystemQuestInfo")] 		public CHandle<CScriptedFlashFunction> M_fxSetSystemQuestInfo { get; set;}

		[Ordinal(11)] [RED("("m_guiManager")] 		public CHandle<CR4GuiManager> M_guiManager { get; set;}

		[Ordinal(12)] [RED("("m_hud")] 		public CHandle<CR4ScriptedHud> M_hud { get; set;}

		[Ordinal(13)] [RED("("_highlightedObjective")] 		public CHandle<CJournalQuestObjective> _highlightedObjective { get; set;}

		public CR4HudModuleQuests(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4HudModuleQuests(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}