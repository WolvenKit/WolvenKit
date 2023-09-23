using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ScoreboardLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("gridItem")] 
		public CName GridItem
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("namesWidget")] 
		public inkCompoundWidgetReference NamesWidget
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("scoresWidget")] 
		public inkCompoundWidgetReference ScoresWidget
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("highScores")] 
		public CArray<ScoreboardPlayer> HighScores
		{
			get => GetPropertyValue<CArray<ScoreboardPlayer>>();
			set => SetPropertyValue<CArray<ScoreboardPlayer>>(value);
		}

		public ScoreboardLogicController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
