using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ItemLabelController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("moneyIcon")] 
		public inkImageWidgetReference MoneyIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("type")] 
		public CEnum<ItemLabelType> Type
		{
			get => GetPropertyValue<CEnum<ItemLabelType>>();
			set => SetPropertyValue<CEnum<ItemLabelType>>(value);
		}

		public ItemLabelController()
		{
			Label = new inkTextWidgetReference();
			MoneyIcon = new inkImageWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
