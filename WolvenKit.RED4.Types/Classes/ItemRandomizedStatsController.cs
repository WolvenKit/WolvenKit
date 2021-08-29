using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ItemRandomizedStatsController : inkWidgetLogicController
	{
		private inkTextWidgetReference _statName;

		[Ordinal(1)] 
		[RED("statName")] 
		public inkTextWidgetReference StatName
		{
			get => GetProperty(ref _statName);
			set => SetProperty(ref _statName, value);
		}
	}
}
