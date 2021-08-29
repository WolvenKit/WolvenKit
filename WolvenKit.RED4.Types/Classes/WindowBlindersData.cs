using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WindowBlindersData : RedBaseClass
	{
		private CEnum<EWindowBlindersStates> _windowBlindersState;
		private CBool _hasOpenInteraction;
		private CBool _hasTiltInteraction;
		private CBool _hasQuickHack;

		[Ordinal(0)] 
		[RED("windowBlindersState")] 
		public CEnum<EWindowBlindersStates> WindowBlindersState
		{
			get => GetProperty(ref _windowBlindersState);
			set => SetProperty(ref _windowBlindersState, value);
		}

		[Ordinal(1)] 
		[RED("hasOpenInteraction")] 
		public CBool HasOpenInteraction
		{
			get => GetProperty(ref _hasOpenInteraction);
			set => SetProperty(ref _hasOpenInteraction, value);
		}

		[Ordinal(2)] 
		[RED("hasTiltInteraction")] 
		public CBool HasTiltInteraction
		{
			get => GetProperty(ref _hasTiltInteraction);
			set => SetProperty(ref _hasTiltInteraction, value);
		}

		[Ordinal(3)] 
		[RED("hasQuickHack")] 
		public CBool HasQuickHack
		{
			get => GetProperty(ref _hasQuickHack);
			set => SetProperty(ref _hasQuickHack, value);
		}
	}
}
