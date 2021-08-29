using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RevealDevicesGridOnEntityEvent : redEvent
	{
		private CBool _shouldDraw;

		[Ordinal(0)] 
		[RED("shouldDraw")] 
		public CBool ShouldDraw
		{
			get => GetProperty(ref _shouldDraw);
			set => SetProperty(ref _shouldDraw, value);
		}
	}
}
