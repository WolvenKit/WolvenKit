using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questMinigameNodeDefinition : questSignalStoppingNodeDefinition
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

		public questMinigameNodeDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
