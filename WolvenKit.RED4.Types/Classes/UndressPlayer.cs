using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UndressPlayer : redEvent
	{
		private CBool _isCensored;

		[Ordinal(0)] 
		[RED("isCensored")] 
		public CBool IsCensored
		{
			get => GetProperty(ref _isCensored);
			set => SetProperty(ref _isCensored, value);
		}
	}
}
