using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ItemTooltipAttributeRequirement : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("labelRef")] 
		public inkTextWidgetReference LabelRef
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		public ItemTooltipAttributeRequirement()
		{
			LabelRef = new inkTextWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
