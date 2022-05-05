using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RipperdocIdPanel : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("fluffContainer")] 
		public inkWidgetReference FluffContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("nameLabel")] 
		public inkTextWidgetReference NameLabel
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("moneyLabel")] 
		public inkTextWidgetReference MoneyLabel
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		public RipperdocIdPanel()
		{
			FluffContainer = new();
			NameLabel = new();
			MoneyLabel = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
