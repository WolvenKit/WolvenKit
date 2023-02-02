using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiMinigameState : IScriptable
	{
		[Ordinal(0)] 
		[RED("currentLives")] 
		public CInt32 CurrentLives
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("currentScore")] 
		public CInt32 CurrentScore
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public gameuiMinigameState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
