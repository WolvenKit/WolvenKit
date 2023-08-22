
namespace WolvenKit.RED4.Types
{
	public partial class gameuiPanzerGameState : gameuiSideScrollerMiniGameStateAdvanced
	{
		public gameuiPanzerGameState()
		{
			OpertyMaxScore = "m_maxScore";
			OpertyCurrentLives = "m_currentLives";
			OpertyCurrentScore = "m_currentScore";
			PropertyChanged_ = new gameuiGameStatePropertyChangedCallback();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
