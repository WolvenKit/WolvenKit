using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiPanzerScoreBoard : gameuiSideScrollerMiniGameDynObjectLogicAdvanced
	{
		[Ordinal(1)] 
		[RED("scoreboardList")] 
		public inkVerticalPanelWidgetReference ScoreboardList
		{
			get => GetPropertyValue<inkVerticalPanelWidgetReference>();
			set => SetPropertyValue<inkVerticalPanelWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("champions")] 
		public CArray<gameuiPanzerScoreRecordData> Champions
		{
			get => GetPropertyValue<CArray<gameuiPanzerScoreRecordData>>();
			set => SetPropertyValue<CArray<gameuiPanzerScoreRecordData>>(value);
		}

		[Ordinal(3)] 
		[RED("recordWidgetLibraryName")] 
		public CName RecordWidgetLibraryName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameuiPanzerScoreBoard()
		{
			ScoreboardList = new inkVerticalPanelWidgetReference();
			Champions = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
