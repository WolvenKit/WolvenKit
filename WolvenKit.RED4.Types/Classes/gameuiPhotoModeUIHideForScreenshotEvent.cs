using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiPhotoModeUIHideForScreenshotEvent : redEvent
	{
		private CBool _hide;

		[Ordinal(0)] 
		[RED("hide")] 
		public CBool Hide
		{
			get => GetProperty(ref _hide);
			set => SetProperty(ref _hide, value);
		}
	}
}
