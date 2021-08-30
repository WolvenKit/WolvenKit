using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questMinigameNodeDefinition : questSignalStoppingNodeDefinition
	{
		private CBool _start;
		private CBool _skipSummaryScreen;
		private gameEntityReference _networkRef;

		[Ordinal(2)] 
		[RED("start")] 
		public CBool Start
		{
			get => GetProperty(ref _start);
			set => SetProperty(ref _start, value);
		}

		[Ordinal(3)] 
		[RED("skipSummaryScreen")] 
		public CBool SkipSummaryScreen
		{
			get => GetProperty(ref _skipSummaryScreen);
			set => SetProperty(ref _skipSummaryScreen, value);
		}

		[Ordinal(4)] 
		[RED("networkRef")] 
		public gameEntityReference NetworkRef
		{
			get => GetProperty(ref _networkRef);
			set => SetProperty(ref _networkRef, value);
		}

		public questMinigameNodeDefinition()
		{
			_start = true;
		}
	}
}
