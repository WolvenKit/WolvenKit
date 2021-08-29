using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectObjectFilter_BlockingGeometry : gameEffectObjectGroupFilter
	{
		private CBool _inclusive;
		private CBool _sortQueryResultsByDistance;

		[Ordinal(0)] 
		[RED("inclusive")] 
		public CBool Inclusive
		{
			get => GetProperty(ref _inclusive);
			set => SetProperty(ref _inclusive, value);
		}

		[Ordinal(1)] 
		[RED("sortQueryResultsByDistance")] 
		public CBool SortQueryResultsByDistance
		{
			get => GetProperty(ref _sortQueryResultsByDistance);
			set => SetProperty(ref _sortQueryResultsByDistance, value);
		}
	}
}
