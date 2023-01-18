using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiarcadeArcadeScoreController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("scoreText")] 
		public inkWidgetReference ScoreText
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public gameuiarcadeArcadeScoreController()
		{
			ScoreText = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
