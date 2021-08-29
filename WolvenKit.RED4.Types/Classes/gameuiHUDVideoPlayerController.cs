using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiHUDVideoPlayerController : gameuiHUDGameController
	{
		private CBool _playOnHud;

		[Ordinal(9)] 
		[RED("playOnHud")] 
		public CBool PlayOnHud
		{
			get => GetProperty(ref _playOnHud);
			set => SetProperty(ref _playOnHud, value);
		}
	}
}
