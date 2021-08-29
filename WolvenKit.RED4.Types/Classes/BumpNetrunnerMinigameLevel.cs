using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BumpNetrunnerMinigameLevel : gamePlayerScriptableSystemRequest
	{
		private CInt32 _completedMinigameLevel;

		[Ordinal(1)] 
		[RED("completedMinigameLevel")] 
		public CInt32 CompletedMinigameLevel
		{
			get => GetProperty(ref _completedMinigameLevel);
			set => SetProperty(ref _completedMinigameLevel, value);
		}
	}
}
