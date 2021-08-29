using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EndLookatEvent : redEvent
	{
		private CBool _repeat;

		[Ordinal(0)] 
		[RED("repeat")] 
		public CBool Repeat
		{
			get => GetProperty(ref _repeat);
			set => SetProperty(ref _repeat, value);
		}
	}
}
