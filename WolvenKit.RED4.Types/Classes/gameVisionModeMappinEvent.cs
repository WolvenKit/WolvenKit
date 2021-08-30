using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameVisionModeMappinEvent : redEvent
	{
		private CBool _show;

		[Ordinal(0)] 
		[RED("show")] 
		public CBool Show
		{
			get => GetProperty(ref _show);
			set => SetProperty(ref _show, value);
		}

		public gameVisionModeMappinEvent()
		{
			_show = true;
		}
	}
}
