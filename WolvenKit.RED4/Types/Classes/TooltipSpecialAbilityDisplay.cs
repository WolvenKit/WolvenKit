using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TooltipSpecialAbilityDisplay : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("AbilityIcon")] 
		public inkImageWidgetReference AbilityIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("AbilityDescription")] 
		public inkTextWidgetReference AbilityDescription
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("QualityRoot")] 
		public inkWidgetReference QualityRoot
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public TooltipSpecialAbilityDisplay()
		{
			AbilityIcon = new inkImageWidgetReference();
			AbilityDescription = new inkTextWidgetReference();
			QualityRoot = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
