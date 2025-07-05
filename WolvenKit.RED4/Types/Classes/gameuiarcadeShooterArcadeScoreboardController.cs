using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiarcadeShooterArcadeScoreboardController : gameuiarcadeArcadeScoreboardController
	{
		[Ordinal(8)] 
		[RED("scoreBackground")] 
		public inkWidgetReference ScoreBackground
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("endingScoreBackground")] 
		public inkWidgetReference EndingScoreBackground
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("playerNames")] 
		public inkWidgetReference PlayerNames
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("ranks")] 
		public inkWidgetReference Ranks
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("scores")] 
		public inkWidgetReference Scores
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("highestScoreText")] 
		public inkWidgetReference HighestScoreText
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("highScoreText")] 
		public inkWidgetReference HighScoreText
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("gameOverImage")] 
		public inkImageWidgetReference GameOverImage
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("highestScoreOriginalOffset")] 
		public Vector2 HighestScoreOriginalOffset
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(17)] 
		[RED("highestScoreEndingOffset")] 
		public Vector2 HighestScoreEndingOffset
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(18)] 
		[RED("highScoreTextOriginalOffset")] 
		public Vector2 HighScoreTextOriginalOffset
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(19)] 
		[RED("highScoreTextEndingOffset")] 
		public Vector2 HighScoreTextEndingOffset
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(20)] 
		[RED("rankScoreOriginalOffset")] 
		public Vector2 RankScoreOriginalOffset
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(21)] 
		[RED("rankScoreEndingOffset")] 
		public Vector2 RankScoreEndingOffset
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(22)] 
		[RED("namesOriginalOffset")] 
		public Vector2 NamesOriginalOffset
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(23)] 
		[RED("namesEndingOffset")] 
		public Vector2 NamesEndingOffset
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		public gameuiarcadeShooterArcadeScoreboardController()
		{
			ScoreBackground = new inkWidgetReference();
			EndingScoreBackground = new inkWidgetReference();
			PlayerNames = new inkWidgetReference();
			Ranks = new inkWidgetReference();
			Scores = new inkWidgetReference();
			HighestScoreText = new inkWidgetReference();
			HighScoreText = new inkWidgetReference();
			GameOverImage = new inkImageWidgetReference();
			HighestScoreOriginalOffset = new Vector2();
			HighestScoreEndingOffset = new Vector2();
			HighScoreTextOriginalOffset = new Vector2();
			HighScoreTextEndingOffset = new Vector2();
			RankScoreOriginalOffset = new Vector2();
			RankScoreEndingOffset = new Vector2();
			NamesOriginalOffset = new Vector2();
			NamesEndingOffset = new Vector2();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
