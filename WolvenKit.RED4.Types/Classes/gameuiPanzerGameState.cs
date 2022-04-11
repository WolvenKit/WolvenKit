
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiPanzerGameState : gameuiSideScrollerMiniGameStateAdvanced
	{

		public gameuiPanzerGameState()
		{
			OpertyMaxScore = "m_maxScore";
			OpertyCurrentLives = "m_currentLives";
			OpertyCurrentScore = "m_currentScore";
			PropertyChanged_ = new();
		}
	}
}
