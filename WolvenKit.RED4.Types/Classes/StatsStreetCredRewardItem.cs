using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StatsStreetCredRewardItem : inkButtonController
	{
		private inkTextWidgetReference _levelRef;
		private inkImageWidgetReference _iconRef;
		private CHandle<LevelRewardDisplayData> _data;

		[Ordinal(10)] 
		[RED("levelRef")] 
		public inkTextWidgetReference LevelRef
		{
			get => GetProperty(ref _levelRef);
			set => SetProperty(ref _levelRef, value);
		}

		[Ordinal(11)] 
		[RED("iconRef")] 
		public inkImageWidgetReference IconRef
		{
			get => GetProperty(ref _iconRef);
			set => SetProperty(ref _iconRef, value);
		}

		[Ordinal(12)] 
		[RED("data")] 
		public CHandle<LevelRewardDisplayData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}
	}
}
