using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ToggleNetrunnerDive : ActionBool
	{
		private CBool _skipMinigame;
		private CInt32 _attempt;
		private CBool _isRemote;

		[Ordinal(25)] 
		[RED("skipMinigame")] 
		public CBool SkipMinigame
		{
			get => GetProperty(ref _skipMinigame);
			set => SetProperty(ref _skipMinigame, value);
		}

		[Ordinal(26)] 
		[RED("attempt")] 
		public CInt32 Attempt
		{
			get => GetProperty(ref _attempt);
			set => SetProperty(ref _attempt, value);
		}

		[Ordinal(27)] 
		[RED("isRemote")] 
		public CBool IsRemote
		{
			get => GetProperty(ref _isRemote);
			set => SetProperty(ref _isRemote, value);
		}
	}
}
