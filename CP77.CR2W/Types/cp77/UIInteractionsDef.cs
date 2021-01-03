using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class UIInteractionsDef : gamebbScriptDefinition
	{
		[Ordinal(0)]  [RED("ActiveChoiceHubID")] public gamebbScriptID_Int32 ActiveChoiceHubID { get; set; }
		[Ordinal(1)]  [RED("ActiveInteractions")] public gamebbScriptID_Variant ActiveInteractions { get; set; }
		[Ordinal(2)]  [RED("ContactsData")] public gamebbScriptID_Variant ContactsData { get; set; }
		[Ordinal(3)]  [RED("DialogChoiceHubs")] public gamebbScriptID_Variant DialogChoiceHubs { get; set; }
		[Ordinal(4)]  [RED("HasScrollableInteraction")] public gamebbScriptID_Bool HasScrollableInteraction { get; set; }
		[Ordinal(5)]  [RED("InteractionChoiceHub")] public gamebbScriptID_Variant InteractionChoiceHub { get; set; }
		[Ordinal(6)]  [RED("InteractionSkillCheckHub")] public gamebbScriptID_Variant InteractionSkillCheckHub { get; set; }
		[Ordinal(7)]  [RED("LastAttemptedChoice")] public gamebbScriptID_Variant LastAttemptedChoice { get; set; }
		[Ordinal(8)]  [RED("LookAtTargetVisualizerID")] public gamebbScriptID_Int32 LookAtTargetVisualizerID { get; set; }
		[Ordinal(9)]  [RED("LootData")] public gamebbScriptID_Variant LootData { get; set; }
		[Ordinal(10)]  [RED("NameplateOwnerID")] public gamebbScriptID_EntityID NameplateOwnerID { get; set; }
		[Ordinal(11)]  [RED("SelectedIndex")] public gamebbScriptID_Int32 SelectedIndex { get; set; }
		[Ordinal(12)]  [RED("ShouldHideClampedMappins")] public gamebbScriptID_Bool ShouldHideClampedMappins { get; set; }
		[Ordinal(13)]  [RED("VisualizersInfo")] public gamebbScriptID_Variant VisualizersInfo { get; set; }

		public UIInteractionsDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
