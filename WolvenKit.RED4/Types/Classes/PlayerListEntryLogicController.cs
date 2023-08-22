using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PlayerListEntryLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("playerNameLabel")] 
		public inkWidgetReference PlayerNameLabel
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("playerClassIcon")] 
		public inkImageWidgetReference PlayerClassIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		public PlayerListEntryLogicController()
		{
			PlayerNameLabel = new inkWidgetReference();
			PlayerClassIcon = new inkImageWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
