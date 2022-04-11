using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
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
			MinigameProgram = new();
		}
	}
}
