using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questHUDEntryAnimationFinished : RedBaseClass
	{
		private CName _hudEntry;
		private CName _animationName;
		private CBool _finished;

		[Ordinal(0)] 
		[RED("hudEntry")] 
		public CName HudEntry
		{
			get => GetProperty(ref _hudEntry);
			set => SetProperty(ref _hudEntry, value);
		}

		[Ordinal(1)] 
		[RED("animationName")] 
		public CName AnimationName
		{
			get => GetProperty(ref _animationName);
			set => SetProperty(ref _animationName, value);
		}

		[Ordinal(2)] 
		[RED("finished")] 
		public CBool Finished
		{
			get => GetProperty(ref _finished);
			set => SetProperty(ref _finished, value);
		}
	}
}
