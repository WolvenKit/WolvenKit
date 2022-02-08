using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BumpNetrunnerMinigameLevel : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] 
		[RED("completedMinigameLevel")] 
		public CInt32 CompletedMinigameLevel
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
	}
}
