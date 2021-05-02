using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiPanzerScoreBoard : gameuiSideScrollerMiniGameDynObjectLogicAdvanced
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

		public gameuiPanzerScoreBoard(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
