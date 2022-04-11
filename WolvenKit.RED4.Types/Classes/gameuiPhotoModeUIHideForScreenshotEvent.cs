using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiPhotoModeUIHideForScreenshotEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("hide")] 
		public CBool Hide
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
