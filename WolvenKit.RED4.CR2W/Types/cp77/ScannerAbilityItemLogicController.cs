using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerAbilityItemLogicController : inkWidgetLogicController
	{
		private inkTextWidgetReference _abilityNameText;
		private inkImageWidgetReference _abilityIcon;
		private CHandle<gamedataGameplayAbility_Record> _abilityStruct;

		[Ordinal(1)] 
		[RED("abilityNameText")] 
		public inkTextWidgetReference AbilityNameText
		{
			get => GetProperty(ref _abilityNameText);
			set => SetProperty(ref _abilityNameText, value);
		}

		[Ordinal(2)] 
		[RED("abilityIcon")] 
		public inkImageWidgetReference AbilityIcon
		{
			get => GetProperty(ref _abilityIcon);
			set => SetProperty(ref _abilityIcon, value);
		}

		[Ordinal(3)] 
		[RED("abilityStruct")] 
		public CHandle<gamedataGameplayAbility_Record> AbilityStruct
		{
			get => GetProperty(ref _abilityStruct);
			set => SetProperty(ref _abilityStruct, value);
		}

		public ScannerAbilityItemLogicController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
