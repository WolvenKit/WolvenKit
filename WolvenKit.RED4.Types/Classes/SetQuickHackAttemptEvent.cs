using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SetQuickHackAttemptEvent : redEvent
	{
		private CBool _wasQuickHackAttempt;

		[Ordinal(0)] 
		[RED("wasQuickHackAttempt")] 
		public CBool WasQuickHackAttempt
		{
			get => GetProperty(ref _wasQuickHackAttempt);
			set => SetProperty(ref _wasQuickHackAttempt, value);
		}
	}
}
