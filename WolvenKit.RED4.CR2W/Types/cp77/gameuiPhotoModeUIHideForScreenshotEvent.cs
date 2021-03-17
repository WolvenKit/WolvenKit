using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiPhotoModeUIHideForScreenshotEvent : redEvent
	{
		private CBool _hide;

		[Ordinal(0)] 
		[RED("hide")] 
		public CBool Hide
		{
			get => GetProperty(ref _hide);
			set => SetProperty(ref _hide, value);
		}

		public gameuiPhotoModeUIHideForScreenshotEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
