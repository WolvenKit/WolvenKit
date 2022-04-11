
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiContraGameState : gameuiSideScrollerMiniGameStateAdvanced
	{

		public gameuiContraGameState()
		{
			OpertyMaxScore = "m_maxScore";
			OpertyCurrentLives = "m_currentLives";
			OpertyCurrentScore = "m_currentScore";
			PropertyChanged_ = new();
		}
	}
}
