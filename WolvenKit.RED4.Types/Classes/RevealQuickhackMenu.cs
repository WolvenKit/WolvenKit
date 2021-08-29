using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RevealQuickhackMenu : HUDManagerRequest
	{
		private CBool _shouldOpenWheel;

		[Ordinal(1)] 
		[RED("shouldOpenWheel")] 
		public CBool ShouldOpenWheel
		{
			get => GetProperty(ref _shouldOpenWheel);
			set => SetProperty(ref _shouldOpenWheel, value);
		}
	}
}
