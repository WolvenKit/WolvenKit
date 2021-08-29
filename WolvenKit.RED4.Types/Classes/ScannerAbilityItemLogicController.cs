using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScannerAbilityItemLogicController : inkWidgetLogicController
	{
		private inkTextWidgetReference _abilityNameText;
		private inkImageWidgetReference _abilityIcon;

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
	}
}
