using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InventoryFilterButton : BaseButtonView
	{
		[Ordinal(2)] 
		[RED("Label")] 
		public inkTextWidgetReference Label
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("InputIcon")] 
		public inkImageWidgetReference InputIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("IntroPlayed")] 
		public CBool IntroPlayed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public InventoryFilterButton()
		{
			Label = new();
			InputIcon = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
