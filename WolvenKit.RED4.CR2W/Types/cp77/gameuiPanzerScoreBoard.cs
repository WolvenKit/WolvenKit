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
			get
			{
				if (_scoreboardList == null)
				{
					_scoreboardList = (inkVerticalPanelWidgetReference) CR2WTypeManager.Create("inkVerticalPanelWidgetReference", "scoreboardList", cr2w, this);
				}
				return _scoreboardList;
			}
			set
			{
				if (_scoreboardList == value)
				{
					return;
				}
				_scoreboardList = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("champions")] 
		public CArray<gameuiPanzerScoreRecordData> Champions
		{
			get
			{
				if (_champions == null)
				{
					_champions = (CArray<gameuiPanzerScoreRecordData>) CR2WTypeManager.Create("array:gameuiPanzerScoreRecordData", "champions", cr2w, this);
				}
				return _champions;
			}
			set
			{
				if (_champions == value)
				{
					return;
				}
				_champions = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("recordWidgetLibraryName")] 
		public CName RecordWidgetLibraryName
		{
			get
			{
				if (_recordWidgetLibraryName == null)
				{
					_recordWidgetLibraryName = (CName) CR2WTypeManager.Create("CName", "recordWidgetLibraryName", cr2w, this);
				}
				return _recordWidgetLibraryName;
			}
			set
			{
				if (_recordWidgetLibraryName == value)
				{
					return;
				}
				_recordWidgetLibraryName = value;
				PropertySet(this);
			}
		}

		public gameuiPanzerScoreBoard(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
