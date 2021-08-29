using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CategoryClickedEvent : redEvent
	{
		private gameStatViewData _statsData;

		[Ordinal(0)] 
		[RED("statsData")] 
		public gameStatViewData StatsData
		{
			get => GetProperty(ref _statsData);
			set => SetProperty(ref _statsData, value);
		}
	}
}
