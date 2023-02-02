using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class WorldMapGangItemController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("factionNameText")] 
		public inkTextWidgetReference FactionNameText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("factionIconImage")] 
		public inkImageWidgetReference FactionIconImage
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		public WorldMapGangItemController()
		{
			FactionNameText = new();
			FactionIconImage = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
