using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiPanzerScoreBoard : gameuiSideScrollerMiniGameDynObjectLogicAdvanced
	{
		private inkVerticalPanelWidgetReference _scoreboardList;
		private CArray<gameuiPanzerScoreRecordData> _champions;
		private CName _recordWidgetLibraryName;

		[Ordinal(1)] 
		[RED("scoreboardList")] 
		public inkVerticalPanelWidgetReference ScoreboardList
		{
			get => GetProperty(ref _scoreboardList);
			set => SetProperty(ref _scoreboardList, value);
		}

		[Ordinal(2)] 
		[RED("champions")] 
		public CArray<gameuiPanzerScoreRecordData> Champions
		{
			get => GetProperty(ref _champions);
			set => SetProperty(ref _champions, value);
		}

		[Ordinal(3)] 
		[RED("recordWidgetLibraryName")] 
		public CName RecordWidgetLibraryName
		{
			get => GetProperty(ref _recordWidgetLibraryName);
			set => SetProperty(ref _recordWidgetLibraryName, value);
		}
	}
}
