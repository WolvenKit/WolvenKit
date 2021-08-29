using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIFlatheadSetSoloModeCommand : AIFollowerCommand
	{
		private CBool _soloModeState;

		[Ordinal(5)] 
		[RED("soloModeState")] 
		public CBool SoloModeState
		{
			get => GetProperty(ref _soloModeState);
			set => SetProperty(ref _soloModeState, value);
		}
	}
}
