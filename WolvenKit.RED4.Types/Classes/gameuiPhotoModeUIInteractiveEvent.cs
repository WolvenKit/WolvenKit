using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiPhotoModeUIInteractiveEvent : redEvent
	{
		private CBool _interactive;

		[Ordinal(0)] 
		[RED("interactive")] 
		public CBool Interactive
		{
			get => GetProperty(ref _interactive);
			set => SetProperty(ref _interactive, value);
		}
	}
}
