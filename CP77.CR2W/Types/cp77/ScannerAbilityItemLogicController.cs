using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ScannerAbilityItemLogicController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("abilityIcon")] public inkImageWidgetReference AbilityIcon { get; set; }
		[Ordinal(1)]  [RED("abilityNameText")] public inkTextWidgetReference AbilityNameText { get; set; }
		[Ordinal(2)]  [RED("abilityStruct")] public CHandle<gamedataGameplayAbility_Record> AbilityStruct { get; set; }

		public ScannerAbilityItemLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
