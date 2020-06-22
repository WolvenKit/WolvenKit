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
		[RED("m_systemQuest")] 		public CHandle<CJournalQuest> M_systemQuest { get; set;}

		[RED("m_systemObjectives", 2,0)] 		public CArray<SJournalQuestObjectiveData> M_systemObjectives { get; set;}

		[RED("m_userObjectives", 2,0)] 		public CArray<SJournalQuestObjectiveData> M_userObjectives { get; set;}

		[RED("m_updateEvents", 2,0)] 		public CArray<SUpdateEvent> M_updateEvents { get; set;}

		[RED("manager")] 		public CHandle<CWitcherJournalManager> Manager { get; set;}

		[RED("m_fxShowTrackedQuestSFF")] 		public CHandle<CScriptedFlashFunction> M_fxShowTrackedQuestSFF { get; set;}

		[RED("m_fxUpdateObjectiveCounterSFF")] 		public CHandle<CScriptedFlashFunction> M_fxUpdateObjectiveCounterSFF { get; set;}

		[RED("m_fxUpdateObjectiveHighlightSFF")] 		public CHandle<CScriptedFlashFunction> M_fxUpdateObjectiveHighlightSFF { get; set;}

		[RED("m_fxUpdateObjectiveUnhighlightAllSFF")] 		public CHandle<CScriptedFlashFunction> M_fxUpdateObjectiveUnhighlightAllSFF { get; set;}

		[RED("m_fxSetSystemQuestInfo")] 		public CHandle<CScriptedFlashFunction> M_fxSetSystemQuestInfo { get; set;}

		[RED("m_guiManager")] 		public CHandle<CR4GuiManager> M_guiManager { get; set;}

		[RED("m_hud")] 		public CHandle<CR4ScriptedHud> M_hud { get; set;}

		[RED("_highlightedObjective")] 		public CHandle<CJournalQuestObjective> _highlightedObjective { get; set;}

		public CR4HudModuleQuests(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4HudModuleQuests(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}