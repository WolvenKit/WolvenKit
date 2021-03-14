using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerAbilityItemLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("abilityNameText")] public inkTextWidgetReference AbilityNameText { get; set; }
		[Ordinal(2)] [RED("abilityIcon")] public inkImageWidgetReference AbilityIcon { get; set; }
		[Ordinal(3)] [RED("abilityStruct")] public CHandle<gamedataGameplayAbility_Record> AbilityStruct { get; set; }

		public ScannerAbilityItemLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
