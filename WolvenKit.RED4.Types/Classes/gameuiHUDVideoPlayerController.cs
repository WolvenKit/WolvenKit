using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiHUDVideoPlayerController : gameuiHUDGameController
	{
		[Ordinal(9)] 
		[RED("playOnHud")] 
		public CBool PlayOnHud
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
