using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TooltipSpecialAbilityDisplay : inkWidgetLogicController
	{
		private inkImageWidgetReference _abilityIcon;
		private inkTextWidgetReference _abilityDescription;
		private inkWidgetReference _qualityRoot;

		[Ordinal(1)] 
		[RED("AbilityIcon")] 
		public inkImageWidgetReference AbilityIcon
		{
			get => GetProperty(ref _abilityIcon);
			set => SetProperty(ref _abilityIcon, value);
		}

		[Ordinal(2)] 
		[RED("AbilityDescription")] 
		public inkTextWidgetReference AbilityDescription
		{
			get => GetProperty(ref _abilityDescription);
			set => SetProperty(ref _abilityDescription, value);
		}

		[Ordinal(3)] 
		[RED("QualityRoot")] 
		public inkWidgetReference QualityRoot
		{
			get => GetProperty(ref _qualityRoot);
			set => SetProperty(ref _qualityRoot, value);
		}
	}
}
