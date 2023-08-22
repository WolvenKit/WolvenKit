using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class StatsStreetCredRewardItem : inkButtonController
	{
		[Ordinal(10)] 
		[RED("levelRef")] 
		public inkTextWidgetReference LevelRef
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("iconRef")] 
		public inkImageWidgetReference IconRef
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("data")] 
		public CHandle<LevelRewardDisplayData> Data
		{
			get => GetPropertyValue<CHandle<LevelRewardDisplayData>>();
			set => SetPropertyValue<CHandle<LevelRewardDisplayData>>(value);
		}

		public StatsStreetCredRewardItem()
		{
			LevelRef = new inkTextWidgetReference();
			IconRef = new inkImageWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
