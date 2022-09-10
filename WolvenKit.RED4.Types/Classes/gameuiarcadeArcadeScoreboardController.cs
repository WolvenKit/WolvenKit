using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiarcadeArcadeScoreboardController : gameuiarcadeIArcadeScreenController
	{
		[Ordinal(1)] 
		[RED("endingPanel")] 
		public inkWidgetReference EndingPanel
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("playerCurrentScore")] 
		public inkTextWidgetReference PlayerCurrentScore
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("playerHighestScore")] 
		public inkTextWidgetReference PlayerHighestScore
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("playerHighestScoreAlert")] 
		public inkTextWidgetReference PlayerHighestScoreAlert
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("pressToPlayAgainText")] 
		public inkWidgetReference PressToPlayAgainText
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("scoreboardNameList")] 
		public CArray<inkTextWidgetReference> ScoreboardNameList
		{
			get => GetPropertyValue<CArray<inkTextWidgetReference>>();
			set => SetPropertyValue<CArray<inkTextWidgetReference>>(value);
		}

		[Ordinal(7)] 
		[RED("scoreboardScoreList")] 
		public CArray<inkTextWidgetReference> ScoreboardScoreList
		{
			get => GetPropertyValue<CArray<inkTextWidgetReference>>();
			set => SetPropertyValue<CArray<inkTextWidgetReference>>(value);
		}

		public gameuiarcadeArcadeScoreboardController()
		{
			EndingPanel = new();
			PlayerCurrentScore = new();
			PlayerHighestScore = new();
			PlayerHighestScoreAlert = new();
			PressToPlayAgainText = new();
			ScoreboardNameList = new();
			ScoreboardScoreList = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
