using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScannerAbilityItemLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("abilityNameText")] 
		public inkTextWidgetReference AbilityNameText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("abilityIcon")] 
		public inkImageWidgetReference AbilityIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		public ScannerAbilityItemLogicController()
		{
			AbilityNameText = new();
			AbilityIcon = new();
		}
	}
}
