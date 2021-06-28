using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScoreboardLogicController : inkWidgetLogicController
	{
		private CName _gridItem;
		private inkCompoundWidgetReference _namesWidget;
		private inkCompoundWidgetReference _scoresWidget;
		private CArray<ScoreboardPlayer> _highScores;

		[Ordinal(1)] 
		[RED("gridItem")] 
		public CName GridItem
		{
			get => GetProperty(ref _gridItem);
			set => SetProperty(ref _gridItem, value);
		}

		[Ordinal(2)] 
		[RED("namesWidget")] 
		public inkCompoundWidgetReference NamesWidget
		{
			get => GetProperty(ref _namesWidget);
			set => SetProperty(ref _namesWidget, value);
		}

		[Ordinal(3)] 
		[RED("scoresWidget")] 
		public inkCompoundWidgetReference ScoresWidget
		{
			get => GetProperty(ref _scoresWidget);
			set => SetProperty(ref _scoresWidget, value);
		}

		[Ordinal(4)] 
		[RED("highScores")] 
		public CArray<ScoreboardPlayer> HighScores
		{
			get => GetProperty(ref _highScores);
			set => SetProperty(ref _highScores, value);
		}

		public ScoreboardLogicController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
