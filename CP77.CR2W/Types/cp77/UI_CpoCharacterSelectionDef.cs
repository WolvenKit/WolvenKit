using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class UI_CpoCharacterSelectionDef : gamebbScriptDefinition
	{
		[Ordinal(0)]  [RED("CharacterRecordId")] public gamebbScriptID_Variant CharacterRecordId { get; set; }
		[Ordinal(1)]  [RED("SelectionMenuVisible")] public gamebbScriptID_Bool SelectionMenuVisible { get; set; }

		public UI_CpoCharacterSelectionDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
