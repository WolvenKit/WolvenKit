using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UnlockMinigameProgramEffector : gameEffector
	{
		private gameuiMinigameProgramData _minigameProgram;

		[Ordinal(0)] 
		[RED("minigameProgram")] 
		public gameuiMinigameProgramData MinigameProgram
		{
			get => GetProperty(ref _minigameProgram);
			set => SetProperty(ref _minigameProgram, value);
		}
	}
}
