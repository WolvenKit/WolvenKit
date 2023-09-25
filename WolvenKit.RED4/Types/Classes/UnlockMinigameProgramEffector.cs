using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UnlockMinigameProgramEffector : gameEffector
	{
		[Ordinal(0)] 
		[RED("minigameProgram")] 
		public gameuiMinigameProgramData MinigameProgram
		{
			get => GetPropertyValue<gameuiMinigameProgramData>();
			set => SetPropertyValue<gameuiMinigameProgramData>(value);
		}

		public UnlockMinigameProgramEffector()
		{
			MinigameProgram = new gameuiMinigameProgramData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
